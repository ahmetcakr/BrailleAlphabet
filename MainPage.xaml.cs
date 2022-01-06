using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp02
{
    
    public partial class MainPage : ContentPage
    {
        private int _index = 0;  // Dizilerin içinde sürekli artacak değer.

        private string[] _quotes = new string[]
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

        };   // Harf Dizisi

        private string[] _images = new string[]
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
        };   // Harflerin image Dizisi


        public MainPage()
        {
            InitializeComponent();

            currentQuote.Text = _quotes[_index];    // Anlık harf kaynağı için oluşturulan değişken ve harf dizisine eşitlendi.

            imageList.Source = _images[_index];     // Braille alfabesi fotoğraflarının kaynağı ve images dizisine eşitlendi.

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _index++;

            if (_index >= _quotes.Length)         // index'in sayısı harf dizisinin toplam veri sayısını geçerse aşağıdakileri uygula. 
            
                _index = 0;
            
            currentQuote.Text = _quotes[_index];
            imageList.Source = _images[_index];
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
       
               

            if (_index < _quotes.Length) {            // eğer index sayısı harf dizisinin toplam veri sayısının altındaysa bunları uygula.

                 _index--;

                currentQuote.Text = _quotes[_index];
                imageList.Source = _images[_index];

                if (_index<=0)
                { 
                    DisplayAlert("UYARI","Ilk Harfe Geri Döndünüz.\nLütfen 'Next' Butonu Ile Devam Ediniz. ","OK");
                    // ilk harfe geldiğince çalışan uyarı
                   
                }

            }

        }

        private void Button_Clicked_2(object sender, EventArgs e)   // Braille alfabesi nedir butonu
        {
            DisplayAlert("Braille Alfabesi", "Braille alfabesi veya Körler alfabesi;\n\n" +
                " 1821 yılında Louis Braille tarafından geliştirilmiş görme engelli insanların okuyup yazması için kullanılan bir alfabe yöntemidir.\n" +
                " İki kolon taşıyan dikdörtgen düzen üzerine dizilmiş altı kabartılmış noktadan oluşur. \n" +
                "Her iki kolonda üçer nokta bulunur. Noktalardan her biri altmışdört farklı kombinasyondan birini oluşturması için farklı şekillerde dizilir. ", "OK");
        }
    }
    }
