namespace EventsDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public required Video Video { get; set; }
    }

    public class VideoEncoder
    {

        // 1. Define a delegate: 
        // signature of method in subscriber called when publisher publishes event

        // 2. Define an event based on delegate

        // 3. method which raises the event

        // old approach
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // public event VideoEncodedEventHandler VideoEncoded;

        // new approach
        public event EventHandler<VideoEventArgs>? VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video.....");
            Thread.Sleep(3000);
            // call the event to notify all subscribers
            OnVideoEncoded(video);
        }


        // VideoEncoded is a pointer to all the services subscribed to the event
        // if it is not empty, it has a pointer to event handler method and calls it
        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
            // if (VideoEncoded != null)
            // {
            //     VideoEncoded(this, new VideoEventArgs() { Video = video });
            // }
            // this is what essentially is happening

        }
    }
}