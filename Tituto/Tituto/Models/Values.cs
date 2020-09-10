namespace Tituto.Models
{
    public class Values
    {
        private int expEarn = 60;
        private int expToEarn = 100;
        private int FirstQuizPkt = 21;
        private int SecondQuizPkt = 46;
        private int ThirdQuizPkt = 83;
        private int FourthQuizPkt = 37;

        public int ExpEarn { get => expEarn; set => expEarn = value; }
        public int ExpToEarn { get => expToEarn; set => expToEarn = value; }
        public int FirstQuizPkt1 { get => FirstQuizPkt; set => FirstQuizPkt = value; }
        public int SecondQuizPkt1 { get => SecondQuizPkt; set => SecondQuizPkt = value; }
        public int ThirdQuizPkt1 { get => ThirdQuizPkt; set => ThirdQuizPkt = value; }
        public int FourthQuizPkt1 { get => FourthQuizPkt; set => FourthQuizPkt = value; }

        public Values() { }
    }
}
