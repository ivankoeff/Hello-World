//package uni.projects.at.hangman;
//
//import android.content.Context;
//import android.view.LayoutInflater;
//import android.view.View;
//import android.view.ViewGroup;
//import android.widget.ArrayAdapter;
//import android.widget.TextView;
//
//import java.security.AccessControlContext;
//import java.util.ArrayList;
//import java.util.List;
//
//public class UserAdapter extends ArrayAdapter<User> {
//    public UserAdapter(AccessControlContext context, int resource, ArrayList<String> objects) {
//        super(context, resource, objects);
//    }
//    @Override
//    public View getView(int position, View convertView, ViewGroup parent) {
//
//        if (convertView == null)        {
//
//            LayoutInflater inflater = ((WelcomeActivity)getContext()).getLayoutInflater ();  // we get a reference to the activity
//            convertView = inflater.inflate (R.layout.user_row_layout, parent, false);
//        }
//
//        TextView usernameTV = convertView.findViewById(R.id.usernameTV);
//        TextView playButtonTV = convertView.findViewById(R.id.playButtonTV);
//
//        usernameTV.setText(getItem(position).username);
//        playButtonTV.setText("Send word");
//
//        return convertView;
//    }
//
//
//
//}
