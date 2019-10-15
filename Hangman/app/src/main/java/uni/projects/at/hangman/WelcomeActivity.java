package uni.projects.at.hangman;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

public class WelcomeActivity extends AppCompatActivity {

    TextView titleText;
    TextView playTextbutton;
    TextView playersListTextbutton;
    TextView mailTextbutton;
    TextView scoreTextbutton;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_welcome);

        titleText = findViewById(R.id.titleTextView);
        playTextbutton = findViewById(R.id.playTextView);
        playersListTextbutton = findViewById(R.id.listTextView);
        mailTextbutton = findViewById(R.id.mailTextView);
        scoreTextbutton = findViewById(R.id.scoreTextView);

        titleText.setOnClickListener(onClick);
        playTextbutton.setOnClickListener(onClick);
        playersListTextbutton.setOnClickListener(onClick);
        mailTextbutton.setOnClickListener(onClick);
        scoreTextbutton.setOnClickListener(onClick);


    }
    private View.OnClickListener onClick = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            Intent intent = null;
            switch (v.getId()){
                case R.id.playTextView:
                    intent = new Intent(WelcomeActivity.this, PlayActivity.class);
                    startActivity(intent);
                    finish();
                    break;
//                case R.id.listTextView:
//                    intent = new Intent(WelcomeActivity.this, PlayersListActivity.class);
//                    startActivity(intent);
//                    finish();
//                    break;
                case R.id.mailTextView:
                    intent = new Intent(WelcomeActivity.this, MailActivity.class);
                    startActivity(intent);
                    finish();
                    break;
                case R.id.titleTextView:
                    Toast.makeText(WelcomeActivity.this, "I'm just a title, stop clicking me!", Toast.LENGTH_LONG).show();
                    break;
                case R.id.scoreTextView:
                    intent = new Intent(WelcomeActivity.this, ScoreActivity.class);
                    startActivity(intent);
                    finish();
            }

        }
    };
}

