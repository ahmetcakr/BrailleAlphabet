using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace FirstApp02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
       
        /*private string[] _letter = new string[]
        {
            " A HARFİ ",
            " B HARFİ ",
            " C HARFİ ",
            " D HARFİ ",
            " E HARFİ ",
            " F HARFİ ",
            " G HARFİ ",
            " H HARFİ ",
            " I HARFİ ",
            " J HARFİ ",
            " K HARFİ ",
            " L HARFİ ",
            " M HARFİ ",
            " N HARFİ ",
            " O HARFİ ",
            " P HARFİ ",
            " Q HARFİ ",
            " R HARFİ ",
            " S HARFİ ",
            " T HARFİ ",
            " U HARFİ ",
            " V HARFİ ",
            " W HARFİ ",
            " X HARFİ ",
            " Y HARFİ ",
            " Z HARFİ ",

        };*/  // kullanılmayan dizi
        private string[] _brailleletters = new string[]
       {
             "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Braille_A1.svg/86px-Braille_A1.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Braille_B2.svg/86px-Braille_B2.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Braille_C3.svg/86px-Braille_C3.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3b/Braille_D4.svg/86px-Braille_D4.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Braille_E5.svg/86px-Braille_E5.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Braille_F6.svg/86px-Braille_F6.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Braille_G7.svg/86px-Braille_G7.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Braille_H8.svg/86px-Braille_H8.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Braille_I9.svg/86px-Braille_I9.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e9/Braille_J0.svg/86px-Braille_J0.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Braille_K.svg/86px-Braille_K.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/f/ff/Braille_L.svg/86px-Braille_L.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Braille_M.svg/86px-Braille_M.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/Braille_N.svg/86px-Braille_N.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6b/Braille_O.svg/86px-Braille_O.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Braille_P.svg/86px-Braille_P.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Braille_Q.svg/86px-Braille_Q.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Braille_R.svg/86px-Braille_R.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Braille_S.svg/86px-Braille_S.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/Braille_T.svg/86px-Braille_T.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Braille_U.svg/86px-Braille_U.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f1/Braille_V.svg/86px-Braille_V.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/3/37/Braille_W.svg/86px-Braille_W.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Braille_X.svg/86px-Braille_X.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3b/Braille_Y.svg/86px-Braille_Y.svg.png",
             "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Braille_Z.svg/86px-Braille_Z.svg.png"
       };   // Braille alfabesinin resim dosya uzantıları

        public void imagename(int a)
        {
            brailleimages.Source = _brailleletters[a];  // switch case içerisine eklenecek, Brailler fotoğraf adresi functionu
        }


        public MainPage2()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            switch (textalani.Text)
            {
                case "a":
                case "A":
                    imagename(0); // _brailleletters dizisinin ilk elemanı
                    break;
                case "b":
                case "B":
                    imagename(1);
                    break;
                case "c":
                case "C":
                    imagename(2);
                    break;
                case "d":
                case "D":
                    imagename(3);
                    break;
                case "e":
                case "E":
                    imagename(4);
                    break;
                case "f":
                case "F":
                    imagename(5);
                    break;
                case "g":
                case "G":
                    imagename(6);
                    break;
                case "h":
                case "H":
                    imagename(7);
                    break;
                case "ı":
                case "I":
                    imagename(8);
                    break;
                case "j":
                case "J":
                    imagename(9);
                    break;
                case "k":
                case "K":
                    imagename(10);
                    break;
                case "l":
                case "L":
                    imagename(11);
                    break;
                case "m":
                case "M":
                    imagename(12);
                    break;
                case "n":
                case "N":
                    imagename(13);
                    break;
                case "o":
                case "O":
                    imagename(14);
                    break;
                case "p":
                case "P":
                    imagename(15);
                    break;
                case "q":
                case "Q":
                    imagename(16);
                    break;
                case "r":
                case "R":
                    imagename(17);
                    break;
                case "s":
                case "S":
                    imagename(18);
                    break;
                case "t":
                case "T":
                    imagename(19);
                    break;
                case "u":
                case "U":
                    imagename(20);
                    break;
                case "v":
                case "V":
                    imagename(21);
                    break;
                case "w":
                case "W":
                    imagename(22);
                    break;
                case "x":
                case "X":
                    imagename(23);
                    break;
                case "y":
                case "Y":
                    imagename(24);
                    break;
                case "z":
                case "Z":
                    imagename(25);
                    break;

                default:
                    DisplayAlert("UYARI", "LÜTFEN BİR HARF GİRİNİZ!", "OK");
                    break;
            }
        }
    }
}