﻿using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Droid.Views;
using Collections.Core.ViewModels.Samples.SpecificPositions;

namespace Collections.Droid.Views
{
    [Activity(Label = "Specific Positions", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SpecificPositionsView : MvxActivity
    {
        public new SpecificPositionsViewModel ViewModel
        {
            get { return (SpecificPositionsViewModel) base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_SpecificPositions);
        }
    }
}