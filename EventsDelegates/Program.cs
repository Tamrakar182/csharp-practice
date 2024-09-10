namespace EventsDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Skibiddi Toilet Ep, 400" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var smsService = new SMSService(); //another subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            // here we pass the reference of OnVideoEncoded to VideoEncoded, so
            // mailService "subscribes" to VideoEncoded

            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;
            // here we pass the reference of OnVideoEncoded to VideoEncoded, so
            // smsService "subscribes" to VideoEncoded

            videoEncoder.Encode(video);
        }

    }

    public class MailService
    {
        public void OnVideoEncoded(object? source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }

    public class SMSService
    {
        public void OnVideoEncoded(object? source, VideoEventArgs e)
        {
            Console.WriteLine("SMSService: Sending a SMS..." + e.Video.Title);
        }
    }
}