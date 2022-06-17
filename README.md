# Spectrum

This is a small RSS news reader with several popular categories. It uses some popular RSS feed links.

Dependencies for Xamarin.Android:
- System.ServiceModel.Syndication 6.0.0
- Xamarin.Android.Support.v4 27.0.2
- Xamarin.Android.Support.v7.AppCompat 27.0.2

Application was written on Xamarin.Forms, with some native elements as needed. Native functionality was leveraged on Android platform. 
Built and tested on Android device emulator, API 26.

-> App launches with a simple splash screen

-> Main screen is a login screen, with inputs for name and password. Name is validated using Behavior. 
Login screen does not have any backend logic, so it's not a real, fully functional login. You can input whatever values you want or leave it blank.
Main screen also has a camera image, which is tappable and gets you to an Android native activity, which demonstrates basic leverage of native API 
and allows taking pictures with camera. The image button is attached to the layout programmatically, so it shouldn't show up on iOS platform.
Login screen has a "Login" button, the appearance of which was customized using an Effect (code in Xamarin.Droid.Effects)
User and Password entries appearance was customized using a custom entry Renderer (Xamarin.Android.CustomRenderers)

-> Second screen is the news Categories screen. Tapping any of the categories takes you to a screen with news of that category. 
Weather links to a broken RSS link. I left it like that on purpose.

-> NewsFeed screen is where the news parsed from the RSS feed are displayed. It's a sortable list, using a button in the upper right corner.
It's set as a toggle, so pressing once sorts it alphabetically, but if pressed again it sorts alphabetically in the opposite order.
The news title label was customized with a custom Renderer with bindable property 
(code in Spectrum.Helpers.CustomLabel and on Android side in Xamarin.Android.CustomRenderers.CustomLabelRendered)

-> Tapping any of the news title takes you to the last screen, which is the News screen. It renders the news in a Browser element.


Below are the screenshots of the app, as seen on Android phone emulator:


<img width="456" alt="Screen Shot 2022-06-16 at 7 16 43 PM" src="https://user-images.githubusercontent.com/19519180/174214312-2494e158-cd68-4acf-b080-fc863545a1c0.png">
<img width="439" alt="Screen Shot 2022-06-16 at 7 16 54 PM" src="https://user-images.githubusercontent.com/19519180/174214388-1bf285ce-4c68-4092-87ae-f06e5d63fcc7.png">
<img width="455" alt="Screen Shot 2022-06-16 at 7 17 11 PM" src="https://user-images.githubusercontent.com/19519180/174214416-098715d3-27eb-4dcd-870d-ddd481eda1e4.png">
<img width="431" alt="Screen Shot 2022-06-16 at 7 17 21 PM" src="https://user-images.githubusercontent.com/19519180/174214486-2649e0d1-56c9-4ff0-8584-5952a08f68b0.png">
<img width="417" alt="Screen Shot 2022-06-16 at 7 17 30 PM" src="https://user-images.githubusercontent.com/19519180/174214513-bbe8fe31-026c-4523-8bd5-1e066364353c.png">
<img width="417" alt="Screen Shot 2022-06-16 at 7 18 44 PM" src="https://user-images.githubusercontent.com/19519180/174214525-1eb4551d-cb6c-4550-9f44-772fb8f7f0e5.png">
<img width="446" alt="Screen Shot 2022-06-16 at 7 19 00 PM" src="https://user-images.githubusercontent.com/19519180/174214539-e570542f-a7e0-4e13-9dc1-ed02aaf861c7.png">
<img width="449" alt="Screen Shot 2022-06-16 at 7 19 19 PM" src="https://user-images.githubusercontent.com/19519180/174214545-2baabb26-f929-4a90-8fce-ebfe51cbe34d.png">



