//package uni.projects.at.hangman;
//
//import android.content.Intent;
//import android.database.Cursor;
//import android.database.sqlite.SQLiteDatabase;
//import android.support.v7.app.AppCompatActivity;
//import android.os.Bundle;
//import android.view.View;
//import android.widget.AdapterView;
//import android.widget.ArrayAdapter;
//import android.widget.ListView;
//import android.widget.TextView;
//import android.widget.Toast;
//
//import java.util.ArrayList;
//
//import static java.security.AccessController.getContext;
//
//public class PlayersListActivity extends AppCompatActivity {
//    SQLiteDatabaseHelper db = new SQLiteDatabaseHelper(PlayersListActivity.this);
//    ArrayList<String> listItem;
//    UserAdapter adapter;
//    ListView userList;
//
//    @Override
//    protected void onCreate(Bundle savedInstanceState) {
//        super.onCreate(savedInstanceState);
//        setContentView(R.layout.activity_players_list);
//        userList = findViewById(R.id.userslistListView);
//        listItem = new ArrayList<>();
//        viewData();
//
//    }
//
//    private void viewData()
//    {
//        Cursor cursor = db.getData();
//        if(cursor.getCount()==0)
//        {
//            Toast.makeText(this, "There are no registered players yet", Toast.LENGTH_SHORT).show();
//        }
//        else
//        {
//            while (cursor.moveToNext())
//            {
//                listItem.add(cursor.getString(1));
//            }
//            adapter = new UserAdapter(getContext(),R.layout.user_row_layout ,listItem);
//            userList.setAdapter(adapter);
//        }
//    }
//
//
//}
