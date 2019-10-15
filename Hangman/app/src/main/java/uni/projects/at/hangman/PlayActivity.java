package uni.projects.at.hangman;
import android.content.DialogInterface;
import android.content.Intent;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.LinearLayout.LayoutParams;
import android.view.View;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

public class PlayActivity extends AppCompatActivity {

    ImageView stages; //The stage_picture variable
    TextView tryLetter; //The letter holder variable
    TextView goForItButton; //The button variable
    TextView usedLetters; //The used letters holder
    int badLuckCounter=0; //The counter for bad lucks
    int guessedLetters = 0; //The counter for guessed letters
    //Sample word variable for the game
    String chosenWord;
    int[] usedWords = new int[50];
    int usedWordsCounter=0;
    //int islogged;


    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_play);

        //Picture of the game stages
        stages = findViewById(R.id.stageImageView);
        //The field where letter is entered
        tryLetter = findViewById(R.id.tryLetterEditText);
        //The button for the letter check
        goForItButton = findViewById(R.id.checkLetterButtonTextView);
        //The field where used letters are displayed
        usedLetters = findViewById(R.id.usedLettersTextView);
        //What to happen when the textButton is clicked
        goForItButton.setOnClickListener(onClick);

       //Generating randomly word
        setRandomWord();
        //Creating text views for the letters on the screen
        createTextViews(chosenWord);


        // islogged = getIntent().getIntExtra("IS_LOGGED",0);
    }
    //Click listener set to the textButton
    private View.OnClickListener onClick = new View.OnClickListener()
    {
        @Override
        public void onClick(View v) {
            GetLetter();
        }
    };

    //Retrieving entered letter
    public void GetLetter()
    {
        String enteredLetter = tryLetter.getText().toString();

        //Checking if the field is blank
        if(enteredLetter.length() == 0)
        {
            Toast.makeText(PlayActivity.this, "You have to enter a letter", Toast.LENGTH_SHORT).show();
        }
        else
        {
            CheckLetter(enteredLetter.toLowerCase());
            tryLetter.setText("");
        }
    }

    //Check if the letter is in the word
    public void CheckLetter(String letter)
    {
        Boolean check = false;
        for(int i=0;i<chosenWord.length();i++)
        {
            if(chosenWord.charAt(i) == letter.charAt(0))
            {
                ShowLetterAtIndex(i,letter);
                check=true;
                guessedLetters++;
            }
        }
        if (check==false)
        {
            FalseLetter(letter);
        }
        if(guessedLetters == chosenWord.length())
        {
           // Toast.makeText(this, "Yey, you did it!", Toast.LENGTH_SHORT).show();
            final AlertDialog.Builder builder = new AlertDialog.Builder(PlayActivity.this);
            builder.setMessage("YASSS, BA RAMBO! You won!")
                    .setPositiveButton("Bring on the nex one", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            Intent intent = new Intent(PlayActivity.this,PlayActivity.class);
                            startActivity(intent);
                        }
                    })
                    .setNegativeButton("Enough for today", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            Intent intent = new Intent(PlayActivity.this,WelcomeActivity.class);
                            startActivity(intent);
                        }
                    })
                    .setCancelable(false);
            AlertDialog alert = builder.create();
            alert.show();
        }
    }

    //Show the guessed letter in the correct position
    public void ShowLetterAtIndex(int position, String letterGuessed)
    {
        LinearLayout layoutLetter = findViewById(R.id.wordLayout);
        TextView textView = (TextView) layoutLetter.getChildAt(position);
        textView.setText(letterGuessed);
    }

    //Show the false letter into the false letter box and changes the stages of the game
    public void FalseLetter(String failedLetter)
    {
        String previousFailedLetters = usedLetters.getText().toString();
     usedLetters.setText(previousFailedLetters+ failedLetter+", ");
        badLuckCounter++;
        switch(badLuckCounter)
        {
            case 1:
                stages.setImageResource(R.drawable.stage_1);
                break;
            case 2:
                stages.setImageResource(R.drawable.stage_2);
                break;
            case 3:
                stages.setImageResource(R.drawable.stage_3);
                break;
            case 4:
                stages.setImageResource(R.drawable.stage_4);
              break;
            case 5:
                {
                stages.setImageResource(R.drawable.stage_5);
                    final AlertDialog.Builder builder = new AlertDialog.Builder(PlayActivity.this);
                    builder.setMessage("Oh, firetruck! You lost")
                            .setPositiveButton("Let me try another one", new DialogInterface.OnClickListener() {
                                @Override
                                public void onClick(DialogInterface dialog, int which) {
                                    Intent intent = new Intent(PlayActivity.this,PlayActivity.class);
                                    startActivity(intent);
                                    finish();
                                }
                            })
                            .setNegativeButton("I quit", new DialogInterface.OnClickListener() {
                                @Override
                                public void onClick(DialogInterface dialog, int which) {
                                    Intent intent = new Intent(PlayActivity.this,StartActivity.class);
                                    startActivity(intent);
                                    finish();
                                }
                            })
                            .setCancelable(false);
                    AlertDialog alert = builder.create();
                    alert.show();
                    goForItButton.setVisibility(View.INVISIBLE);

                }
                break;
            }
    }

    //Generates views for the letters of the word
    public void createTextViews(String word)
    {
        LinearLayout linearLayout = findViewById(R.id.wordLayout);

        for (int i=0; i<word.length();i++)
        {
            TextView textView = new TextView(this);
            textView.setLayoutParams(new LayoutParams(LayoutParams.WRAP_CONTENT,
                    LayoutParams.WRAP_CONTENT));
            textView.setText("_");
            textView.setBackgroundColor(0x005599); // hex color 0xAARRGGBB
            textView.setPadding(20, 20, 20, 20);// in pixels (left, top, right, bottom)
            textView.setTextSize(40);
            linearLayout.addView(textView);
        }
    }

    //Choose random word from a array and set it as value of the chosenWord
    public void setRandomWord()
    {
        String randomWords = "butter book yarn quill redundant connect obtainable high pen curved absurd romantic ignorant rob existence decay bless aberrant boil bedroom juvenile cross request support found delightful scary drink flowers dime adorable receptive chief disgusted longing tasteless hissing appear trouble edge wise land perpetual supreme answer spiteful perform wine callous healthy";
        String[] wordsArray = randomWords.split(" ");
        int randomNumber = (int) (Math.random() * wordsArray.length);
        chosenWord = wordsArray[randomNumber];

        //usedWords[usedWordsCounter]=randomNumber;
           /* for(int i=0; i<usedWords.length;i++)
            {
                if(usedWords[i]==randomNumber)
                {
                    setRandomWord();
                }
                else
                {
                    if(usedWordsCounter == usedWords.length)
                    {
                        final AlertDialog.Builder builder = new AlertDialog.Builder(PlayActivity.this);
                        builder.setMessage("Congratulations! You finished the game! YEY!")
                                .setPositiveButton("Rock On!", new DialogInterface.OnClickListener() {
                                    @Override
                                    public void onClick(DialogInterface dialog, int which) {
                                        Intent intent = new Intent(PlayActivity.this,WelcomeActivity.class);
                                        startActivity(intent);
                                    }
                                })
                                .setCancelable(false);
                        AlertDialog alert = builder.create();
                        alert.show();
                        usedWordsCounter=0;
                        for(int j=0;j<usedWords.length;j++)
                        {
                            usedWords[j]=0;
                        }
                    }
                    else
                    {
                        chosenWord = wordsArray[randomNumber];
                        usedWords[usedWordsCounter]=randomNumber;
                        usedWordsCounter++;
                    }

                }
            }*/
    }

    @Override
    public void onBackPressed()
    {
            Intent intent = new Intent(this,WelcomeActivity.class);
            startActivity(intent);
            finish();
    }
}

