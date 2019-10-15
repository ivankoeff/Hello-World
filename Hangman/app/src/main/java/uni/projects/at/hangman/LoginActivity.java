package uni.projects.at.hangman;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class LoginActivity extends AppCompatActivity {

    EditText usernameET;
    EditText passwordET;
    TextView loginButton;
    TextView cancelButton;
   // int islogged = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        usernameET = findViewById(R.id.usernameEditText);
        passwordET = findViewById(R.id.passwordEditText);
        loginButton = findViewById(R.id.loginButtonTextView);
        cancelButton = findViewById(R.id.cancelTextView);

        loginButton.setOnClickListener(onClick);
        cancelButton.setOnClickListener(onClick);

    }
    private View.OnClickListener onClick = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            switch (v.getId())
            {
                case R.id.cancelTextView:
                {
                    Intent intent = new Intent(LoginActivity.this, StartActivity.class);
                    startActivity(intent);
                    finish();
                    break;
                }
                case R.id.loginButtonTextView:
                {
                    String username = usernameET.getText().toString();
                    String password = passwordET.getText().toString();

                    SQLiteDatabaseHelper db = new SQLiteDatabaseHelper(LoginActivity.this);
                            if(db.login(username, password))
                            {
//                                islogged = 1;
//                                Intent senddata = new Intent(LoginActivity.this,PlayActivity.class);
//                                senddata.putExtra("IS_LOGGED",islogged);
//                                startActivity(senddata);

                                Intent intent = new Intent(LoginActivity.this,WelcomeActivity.class);
                                startActivity(intent);
                                finish();
                            }
                            else
                            {
                                Toast.makeText(LoginActivity.this, "Wrong username or password", Toast.LENGTH_SHORT).show();
                            }
                }
            }
        }
    };
}
