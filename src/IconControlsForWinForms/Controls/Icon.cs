using IconControlsForWinForms.Entities;
using IconControlsForWinForms.Logic;
using System.ComponentModel;

namespace IconControlsForWinForms
{
    public class Icon : Control
    {
        private IconType _IconType = IconType.Solid;
        [Category(Constants.NamespacePropertly)]
        public IconType IconType
        {
            get { return _IconType; }
            set
            {
                _IconType = value;
                PaintIconImage();
            }
        }

        private string _IconName = "home";
        [Category(Constants.NamespacePropertly)]
        public string IconName
        {
            get { return _IconName; }
            set
            {
                _IconName = value.ToLower();
                PaintIconImage();
            }
        }

        private Color _IconColor = Color.Black;
        [Category(Constants.NamespacePropertly)]
        public Color IconColor
        {
            get { return _IconColor; }
            set
            {
                _IconColor = value;
                PaintIconImage();
            }
        }

        public Icon()
        {
            PaintIconImage();
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            PaintIconImage();
        }

        private void PaintIconImage()
        {
            BackgroundImage = IconLogic.GetImage(IconType, IconName, IconColor, Size.Width, Size.Height);
        }
    }
}
