/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Menu.MenuForm
{
    public partial class UI_Title : GComponent
    {
        public GButton m_Start;
        public GButton m_About;
        public GButton m_Setting;
        public GTextField m_Title;
        public GTextField m_Description;
        public const string URL = "ui://b807pulodr4bo";

        public static UI_Title CreateInstance()
        {
            return (UI_Title)UIPackage.CreateObject("MenuForm", "Title");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Start = (GButton)GetChild("Start");
            m_About = (GButton)GetChild("About");
            m_Setting = (GButton)GetChild("Setting");
            m_Title = (GTextField)GetChild("Title");
            m_Description = (GTextField)GetChild("Description");
        }
    }
}