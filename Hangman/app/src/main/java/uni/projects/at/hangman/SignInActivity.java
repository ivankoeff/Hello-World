package uni.projects.at.hangman;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

public class SignInActivity extends AppCompatActivity {

    EditText usernameET;
    EditText passwordET;
    EditText repeatpassET;
    EditText nameET;
    RadioGroup genderRG;
    TextView signinButtonTV;
    TextView cancelButtonTV;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_signin);

        usernameET = findViewById(R.id.usernameEditText);
        passwordET = findViewById(R.id.passwordEditText);
        repeatpassET = findViewById(R.id.repeatPasswordEditText);
        nameET = findViewById(R.id.passwordEditText);
        genderRG = findViewById(R.id.genderRadioGroup);
        signinButtonTV = findViewById(R.id.signinButtonTextView);
        cancelButtonTV = findViewById(R.id.cancelTextView);

        signinButtonTV.setOnClickListener(onClick);
        cancelButtonTV.setOnClickListener(onClick);

    }

    View.OnClickListener onClick = new View.OnClickListener() {
        @Override
        public void onClick(View v) {

            switch (v.getId()){

                case R.id.signinButtonTextView:

                    if(usernameET.getText().length() == 0 ||
                            passwordET.getText().length() == 0 ||
                            !passwordET.getText().toString().
                                    equals(repeatpassET.getText().toString())){
                        Toast.makeText(SignInActivity.this, "Something is nof filled correct. Try again.", Toast.LENGTH_SHORT).show();
                        return;
                    }

                    User user = new User(usernameET.getText().toString(),
                            passwordET.getText().toString());

                    //За записване на потребител в локалната база
                    user.setName(nameET.getText().toString());

                    RadioButton genderButton =
                            findViewById(genderRG.getCheckedRadioButtonId());

                    user.setGender(genderButton.getText().toString());

                    SQLiteDatabaseHelper db = new SQLiteDatabaseHelper(SignInActivity.this);

                    if(!db.insertUser(user)){
                        Toast.makeText(
                                SignInActivity.this, "ERROR", Toast.LENGTH_LONG).show();
                        return;
                    }




                case R.id.cancelTextView:
                    Intent intent = new Intent(SignInActivity.this,StartActivity.class);
                    startActivity(intent);
                    finish();
                    break;

            }

        }
    };
}
