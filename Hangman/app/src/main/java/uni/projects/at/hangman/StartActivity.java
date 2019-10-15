package uni.projects.at.hangman;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

public class StartActivity extends AppCompatActivity {

    TextView playbuttontext;
    TextView loginbuttontext;
    TextView signinbuttontext;
    TextView titlebuttontext;
    TextView challengebuttontext;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_start);

        titlebuttontext = findViewById(R.id.titleTextView);
        playbuttontext = findViewById(R.id.playTextView);
        loginbuttontext = findViewById(R.id.loginTextView);
        signinbuttontext = findViewById(R.id.signInTextView);
        challengebuttontext = findViewById(R.id.challengeTextView);


        playbuttontext.setOnClickListener(onClick);
        loginbuttontext.setOnClickListener(onClick);
        signinbuttontext.setOnClickListener(onClick);
        titlebuttontext.setOnClickListener(onClick);
        challengebuttontext.setOnClickListener(onClick);

    }
    private View.OnClickListener onClick = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            Intent intent = null;
            switch (v.getId()){
                case R.id.playTextView:
                    intent = new Intent(StartActivity.this, PlayActivity.class);
                    startActivity(intent);
                    break;
                case R.id.loginTextView:
                    intent = new Intent(StartActivity.this, LoginActivity.class);
                    startActivity(intent);
                    break;
                case R.id.signInTextView:
                    intent = new Intent(StartActivity.this, SignInActivity.class);
                    startActivity(intent);
                    break;
                case R.id.titleTextView:
                    Toast.makeText(StartActivity.this, "I'm just a title, stop clicking me!", Toast.LENGTH_LONG).show();
                    break;
                case R.id.challengeTextView:
                    intent = new Intent(StartActivity.this, SendWordActivity.class);
                    startActivity(intent);
                    break;
            }

        }
    };
}
