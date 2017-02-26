using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;

namespace UI.Base
{
    public class ToggleTextBox : TextBox
    {
        int CurrentIndex = 0;
        Dictionary<int, string> ArrToggleValues = new Dictionary<int, string>();

        public ToggleTextBox() : base()
        {
            
        }

        public static readonly DependencyProperty ToggleValuesProperty = DependencyProperty.Register(
              "ToggleValues", typeof(string), typeof(ToggleTextBox),
                    new FrameworkPropertyMetadata(string.Empty,                         
                      FrameworkPropertyMetadataOptions.AffectsRender,                    
                      OnToggleValueChanged
                      )
            );

        private static void OnToggleValueChanged(DependencyObject defectImageControl, DependencyPropertyChangedEventArgs eventArgs)
        {
            var control             = (ToggleTextBox)defectImageControl;
            control.ToggleValues    = (string)eventArgs.NewValue;
        }



        public string ToggleValues
        {
            get { return (string)GetValue(ToggleValuesProperty); }
            set 
            { 
                SetValue(ToggleValuesProperty, value);

                if (ToggleValues.Length > 0 && ToggleValues.Contains(','))
                {
                    string[] values = ToggleValues.Split(',');
                    for (int index = 0; index < values.Length; index++){
                        ArrToggleValues[index] = values[index];
                    }
                    this.Text = ArrToggleValues[0];

                }
            }
        }

        protected override void OnKeyUp(System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Space)
            {
                if (CurrentIndex == (ArrToggleValues.Count - 1))
                {
                    CurrentIndex = -1;
                }
                CurrentIndex++;
                this.Text = ArrToggleValues[CurrentIndex];
            } 
        }

        protected override void OnPreviewTextInput(System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = true;
            base.OnPreviewTextInput(e);
        }

    }
}
