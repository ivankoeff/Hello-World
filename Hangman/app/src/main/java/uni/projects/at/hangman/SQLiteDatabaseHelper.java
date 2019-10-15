package uni.projects.at.hangman;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

public class SQLiteDatabaseHelper extends SQLiteOpenHelper{

    public static final int VERSION = 1;
    public static final String DB_NAME = "Hangman.db";

    //Име на таблицата
    public static final String TABLE_USER = "users";

    //Колони на таблицата
    public static final String TABLE_USER_ID = "id";
    public static final String TABLE_USER_USERNAME = "username";
    public static final String TABLE_USER_PASSWORD = "password";
    public static final String TABLE_USER_NAME = "name";
    public static final String TABLE_USER_GENDER = "gender";

    //Заявка за създаване на таблица user
    public static final String CREATE_TABLE_USER = "CREATE TABLE " + TABLE_USER
            + "('" + TABLE_USER_ID + "' INTEGER PRIMARY KEY AUTOINCREMENT," +
            "'" + TABLE_USER_USERNAME + "' varchar(50) NOT NULL UNIQUE," +
            "'" + TABLE_USER_PASSWORD + "' varchar(50) NOT NULL," +
            "'" + TABLE_USER_NAME + "' varchar(50)," +
            "'" + TABLE_USER_GENDER + "' varchar DEFAULT '')";
    public static final String MYERROR = "MYERROR";


    public SQLiteDatabaseHelper(Context context) {
        super(context, DB_NAME, null, VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(CREATE_TABLE_USER);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS " + TABLE_USER);
        onCreate(db);
    }

    public boolean insertUser(User user){
        SQLiteDatabase db = null;

        try{
            db = getWritableDatabase();
            ContentValues cv = new ContentValues();
            cv.put(TABLE_USER_USERNAME, user.getUsername());
            cv.put(TABLE_USER_PASSWORD, user.getPassword());
            cv.put(TABLE_USER_NAME, user.getName());
            cv.put(TABLE_USER_GENDER, user.getGender());

            long id = db.insert(TABLE_USER, null, cv);
            if(id != -1)
                return true;

        }catch (SQLException e){
            Log.wtf(MYERROR, e.getMessage());
        }finally {
            if(db != null)
                db.close();
        }

        return false;
    }

    public boolean login(String username, String password) {
        SQLiteDatabase db = null;
        try{
            db = getReadableDatabase();

            String sql = "SELECT * FROM " + TABLE_USER
                    + " WHERE " + TABLE_USER_USERNAME + " = '" + username + "'" +
                    " AND " + TABLE_USER_PASSWORD + " = '" + password + "'";

            Cursor c = db.rawQuery(sql, null);

            return c.moveToFirst();

        }catch (Exception e){
            Log.wtf(MYERROR, e.getMessage());
        }finally {
            if(db != null)
                db.close();
        }
        return false;
    }

   public Cursor getData ()
   {
       SQLiteDatabase db = null;
       Cursor cursor = null;
       try
       {
           db=getReadableDatabase();
           String query = "SELECT " + TABLE_USER_USERNAME + " FROM " + TABLE_USER;
           cursor = db.rawQuery(query,null);
       }
       catch (Exception e)
       {
           Log.wtf(MYERROR, e.getMessage());
       }
       finally
       {
           if(db != null)
               db.close();
       }

       return  cursor;
   }


}
