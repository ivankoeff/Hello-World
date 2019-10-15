package uni.projects.at.hangman;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class SendWordActivity extends AppCompatActivity {

    TextView playButton;
    EditText setWord;
    String word;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_send_word);

        playButton = findViewById(R.id.playbuttonTV);
        setWord=findViewById(R.id.friendsWordEditText);

        playButton.setOnClickListener(onClick);

    }
    private View.OnClickListener onClick = new View.OnClickListener() {
        @Override
        public void onClick(View v)
        {
            word=setWord.getText().toString();
            Intent intent = new Intent(SendWordActivity.this,PlayMultyActivity.class);
            intent.putExtra("SEND_WORD",word);
            startActivity(intent);

        }


    };
}
