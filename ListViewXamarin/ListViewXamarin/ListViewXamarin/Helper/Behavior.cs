using Syncfusion.DataSource.Extensions;
using Syncfusion.GridCommon.ScrollAxis;
using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class Behavior : Behavior<ContentPage>
    {
        #region Fields

        Button SortButton;
        #endregion

        #region Overrides
        protected override void OnAttachedTo(ContentPage bindable)
        {
            SortButton = bindable.FindByName<Button>("sortButton");
            SortButton.Clicked += SortButton_Clicked;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            SortButton.Clicked -= SortButton_Clicked;
            SortButton = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion

        #region Call back
        private void SortButton_Clicked(object sender, EventArgs e)
        {
            var viewModel = SortButton.BindingContext as ContactsViewModel;

            if (viewModel.SortDirection == ListSortDirection.Ascending)
                viewModel.SortDirection = ListSortDirection.Descending;
            else
                viewModel.SortDirection = ListSortDirection.Ascending;
        }
        #endregion
    }
}