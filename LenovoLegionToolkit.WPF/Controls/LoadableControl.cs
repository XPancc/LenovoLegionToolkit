﻿using System;
using System.Windows;
using System.Windows.Controls;
using WPFUI.Controls;

namespace LenovoLegionToolkit.WPF.Controls
{
    public class LoadableControl : UserControl
    {
        private readonly ContentPresenter _contentPresenter = new();
        private readonly ProgressRing _progressRing = new()
        {
            IsIndeterminate = true,
            Width = 24,
            Height = 24,
        };

        private bool _isLoading = true;

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                UpdateLoadingState();
            }
        }

        public double IndicatorWidth
        {
            get => _progressRing.Width;
            set => _progressRing.Width = value;
        }

        public double IndicatorHeight
        {
            get => _progressRing.Height;
            set => _progressRing.Height = value;
        }

        public HorizontalAlignment IndicatorHorizontalAlignment
        {
            get => _progressRing.HorizontalAlignment;
            set => _progressRing.HorizontalAlignment = value;
        }

        public VerticalAlignment IndicatorVerticalAlignment
        {
            get => _progressRing.VerticalAlignment;
            set => _progressRing.VerticalAlignment = value;
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            _contentPresenter.Content = Content;

            var grid = new Grid();
            grid.Children.Add(_contentPresenter);
            grid.Children.Add(_progressRing);

            UpdateLoadingState();

            Content = grid;
        }

        private void UpdateLoadingState()
        {
            _contentPresenter.Visibility = IsLoading ? Visibility.Hidden : Visibility.Visible;
            _progressRing.Visibility = IsLoading ? Visibility.Visible : Visibility.Hidden;
        }
    }
}