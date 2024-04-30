using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Auth;
using Firebase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firebase.Firestore;

namespace DevConnect.Common
{
    public class FirebaseRepository
    {
        static FirebaseApp app;
        public static FirebaseAuth getFirebaseAuth()
        {
            //app instance
            app = FirebaseApp.InitializeApp(Application.Context);

            if (app == null)
            {
                var options = new FirebaseOptions.Builder()
                   .SetProjectId("mobapp-43266")
                   .SetApplicationId("1:1031939974646:android:7e7ac3809bed0dc4c793d7")
                   .SetApiKey("AIzaSyA0rt6m0LVTfP32UYdHr8ph57SR7yXQluk")
                   .SetStorageBucket("mobapp-43266.appspot.com")
                   .Build();

                app = FirebaseApp.InitializeApp(Application.Context, options);

            }

            return FirebaseAuth.GetInstance(app);

        }
        public static FirebaseFirestore GetFirebaseFirestore()
        {
            //app instance
            app = FirebaseApp.InitializeApp(Application.Context);

            if (app == null)
            {
                var options = new FirebaseOptions.Builder()
                   .SetProjectId("mobapp-43266")
                   .SetApplicationId("1:1031939974646:android:7e7ac3809bed0dc4c793d7")
                   .SetApiKey("AIzaSyA0rt6m0LVTfP32UYdHr8ph57SR7yXQluk")
                   .SetStorageBucket("mobapp-43266.appspot.com")
                   .Build();

                app = FirebaseApp.InitializeApp(Application.Context, options);

            }

            return FirebaseFirestore.GetInstance(app);
        }
    }
}