# FaceMaskAppDetection
This project consists of a mobile application that detects if a person wears a mask or not in a video. It combines the output of 2 Azure AI Cognitive Services:

1. [Azure Video Analyzer](https://azure.microsoft.com/en-us/products/video-analyzer/)
2. [Azure Custom Vision](https://azure.microsoft.com/en-us/services/cognitive-services/custom-vision-service/)

The application is written in C# using [Xamarin] (https://dotnet.microsoft.com/en-us/apps/xamarin), which allows to deliver a cross-platform mobile application that can run in Windows, Android, and iOS among other platforms.

App details:

- You can record a local video
- You can upload the video to Azure Video Analyzer
- You can see a list of videos from Azure Video Analyzer service
- You can access the details of a video

Azure Video Analyzer service doesn't tell you if you are wearing a mask or not, but it will return frames from the video. That's where Azure Custom Vision enters: Using Object Detection capabilities from Custom Vision project, I could label "mask" zones and "no-mask" zones. Then, I send the frame from Video Analyzer to Custom Vision so it can tell me if the person is wearing a mask or not.
 
Image 1: Application Menu
![Application Menu](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/pl7w0kf1j97jz062b52i.png)

Image 2: Recording a video
![Recording a video](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/p1tf71el6i4ys9l0zxyf.png)

Image 3: Wearing a mask 
![Wearing a mask](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/qpmilmzs1j09p4u8xol0.png)

Image 4: Accessing the video list
![Accesing the video list](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/x4plwpdrbdyx2t4st7hx.png)

Image 5: Accessing video details: No mask / Mask detection
![Accessing video details: No mask / Mask detection](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/qwq7mpg2vvs48g92cdyj.png)

Image 6: Adding mask and no mask tags
![Adding mask and no mask tags](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/d4k39f0uewn5mtco2kpq.png)

Image 7: Prediction
![Prediction](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/wh1wqnv9810vejvnjilw.png)
