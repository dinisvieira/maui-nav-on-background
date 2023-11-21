# MAUI Android MainPage assignments OnResume break or crash the app
Doing an Android MainPage assignment when the app is backgrounded or during App.xaml.cs OnResume breaks or crashes the app.
The app can either crash immediately or in some other situations the Assignment doesn't happen but it's not longer possible to do any other MainPage assignment afterwards.

Steps to Try:
- Clone and Build Repro project
- Open App
- Click buttons to do Navigations/MainPage assignments (optional)
- Press Home button to put the app in background
- Open app again
     - Notice that app crashed OR app didn't Navigate to the "background page"
- Click buttons to do Navigations/MainPage assignments (optional)
     - Notice Navigations don't work anymore
