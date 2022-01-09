using System;

namespace ChildSafe
{
    class promoteQuote
    {
        private String[] quote_VI =
        {
           "We believe everyone has the right to be safe online",
            "The future of internet security is here",
            "Secures… Without slowing you down",
            "Keep your online activity private and protect your identity, all-in-one.It’s never been easier",
            "Free firewall is your first step to online freedom",
            "We’ve got your back",
            "We protect your privacy, keep you safe online, and safeguard your personal data",
            "Devices + online privacy + identity protection",
            "Simple yet Powerful"
        };
        private String[] quote_EN =
        {
           "We believe everyone has the right to be safe online",
            "The future of internet security is here",
            "Secures… Without slowing you down",
            "Keep your online activity private and protect your identity, all-in-one.It’s never been easier",
            "Free firewall is your first step to online freedom",
            "We’ve got your back",
            "We protect your privacy, keep you safe online, and safeguard your personal data",
            "Devices + online privacy + identity protection",
            "Simple yet Powerful"
        };
        public String getRandomQuote(string lang)
        {
            Random randomNum = new Random();
            if (lang == "VI")
                return quote_VI[randomNum.Next(quote_VI.Length)]; // vietnamese quote
            else if (lang == "EN")
                return quote_EN[randomNum.Next(quote_EN.Length)]; // english quote
            else
                return quote_EN[randomNum.Next(quote_EN.Length)]; // default quote language

        }
        public String getRandomQuote()
        {
            Random randomNum = new Random();
                return quote_EN[randomNum.Next(quote_EN.Length)]; // default quote language

        }
    }
}
