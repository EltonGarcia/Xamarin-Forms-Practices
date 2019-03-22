using System;
using SillyCompany.Mobile.Practices.Presentation.ViewModels;
using Xamarin.Forms;

namespace SillyCompany.Mobile.Practices.Presentation.Views
{
    public class FavoriteSillyDudeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FavoriteSillySquare { get; set; }

        public DataTemplate DefaultSillySquare { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is SillyDudeVmo sillyDudeVmo)
            {
                if (sillyDudeVmo.IsFavorite)
                {
                    return FavoriteSillySquare;
                }
                return DefaultSillySquare;
            }

            return null;
        }
    }
}
