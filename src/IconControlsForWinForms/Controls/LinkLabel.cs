using IconControlsForWinForms.Entities;
using IconControlsForWinForms.Logic;
using System.ComponentModel;

namespace IconControlsForWinForms
{
    public class LinkLabel : System.Windows.Forms.LinkLabel
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

        private int _IconWidth = 25;
        [Category(Constants.NamespacePropertly)]
        public int IconWidth
        {
            get { return _IconWidth; }
            set
            {
                _IconWidth = value;
                PaintIconImage();
            }
        }

        public LinkLabel()
        {
            Size = new Size(151, 32);
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleCenter;
            PaintIconImage();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            AutoSize = false;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void PaintIconImage()
        {
            Image = IconLogic.GetImage(IconType, IconName, IconColor, IconWidth);
        }
    }
}
