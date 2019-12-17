namespace TrailScale
{
    public class Splash
    {
        public string Logo { get; private set;}

        public Splash()
        {
            Logo = LoadLogo();
        }

        private string LoadLogo() => @" ___ __,  _, _ _,     _,  _,  _, _,  __,
  |  |_) /_\ | |     (_  / ` /_\ |   |_ 
  |  | \ | | | | ,   , ) \ , | | | , |  
  ~  ~ ~ ~ ~ ~ ~~~    ~   ~  ~ ~ ~~~ ~~~";
    }
}
