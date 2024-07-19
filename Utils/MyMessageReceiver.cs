using Line.Model.Receive;
using Line.Model.Receive.Event;
using Line.Model.Receive.Message;

namespace LineMessageWH.Utils
{
    public class MyMessageReceiver : IMessageReceiver
    {
        public string GetChannelSercet()
        {
            return "Line Channel Sercet";
        }

        public void OnAccountLink(AccountLinkEvent ev)
        {
            throw new NotImplementedException();
        }

        public void OnAudioMessage(MessageEvent ev, VideoMessage message)
        {
            throw new NotImplementedException();
        }

        public void OnBeacon(BeaconEvent ev)
        {
            throw new NotImplementedException();
        }

        public void OnFileMessage(MessageEvent ev, FileMessage message)
        {
            throw new NotImplementedException();
        }

        public void OnFollow(FollowEvent ev)
        {
            throw new NotImplementedException();
        }

        public void OnImageMessage(MessageEvent ev, ImageMessage message)
        {
            throw new NotImplementedException();
        }

        public void OnJoin(Event ev)
        {
            throw new NotImplementedException();
        }

        public void OnLeave(Event ev)
        {
            throw new NotImplementedException();
        }

        public void OnLocationMessage(MessageEvent ev, LocationMessage message)
        {
            throw new NotImplementedException();
        }

        public void OnMemberJoin(MemberJoinEvent ev)
        {
            throw new NotImplementedException();
        }

        public void OnMemberLeave(MemberLeftEvent ev)
        {
            throw new NotImplementedException();
        }

        public void OnPoseBack(PostBackEvent ev)
        {
            throw new NotImplementedException();
        }

        public void OnStickerMessage(MessageEvent ev, StickerMessage message)
        {
            throw new NotImplementedException();
        }

        public void OnTextMessage(MessageEvent ev, TextMessage message)
        {
            throw new NotImplementedException();
        }

        public void OnUnFollow(Event ev)
        {
            throw new NotImplementedException();
        }

        public void OnUnsend(UnsendEvent ev)
        {
            throw new NotImplementedException();
        }

        public void OnVideoEnd(VideoEvent ev)
        {
            throw new NotImplementedException();
        }

        public void OnVideoMessage(MessageEvent ev, VideoMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
