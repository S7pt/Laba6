namespace Laba4Task2.model
{
    public class AutoOwner
    {
        private string ownerName;
        private int phoneNumber;
        private string autoBrand;
        private string autoColor;
        private string autoNumber;

        public AutoOwner(string ownerName, int phoneNumber, string autoBrand, string autoColor, string autoNumber)
        {
            this.ownerName = ownerName;
            this.phoneNumber = phoneNumber;
            this.autoBrand = autoBrand;
            this.autoColor = autoColor;
            this.autoNumber = autoNumber;
        }

        public override string ToString()
        {
            return " | " + ownerName +" | "+ phoneNumber +" | "+ autoBrand +" | "+ autoColor +" | "+ autoNumber+" | ";
        }

        public void setOwnerName(string ownerName)
        {
            this.ownerName = ownerName;
        }
        public void setPhoneNumber(int phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public void setAutoBrand(string autoBrand)
        {
            this.autoBrand = autoBrand;
        }
        public void setAutoColor(string autoColor)
        {
            this.autoColor = autoColor;
        }
        public void setAutoNumber(string autoNumber)
        {
            this.autoNumber = autoNumber;
        }
        public string getOwnerName()
        {
            return ownerName;
        }
        public int getPhoneNumber()
        {
            return phoneNumber;
        }
        public string getAutoBrand()
        {
            return autoBrand;
        }
        
        public string getAutoColor()
        {
            return autoColor;
        }
        public string getAutoNumber()
        {
            return autoNumber;
        }
        
    }
}