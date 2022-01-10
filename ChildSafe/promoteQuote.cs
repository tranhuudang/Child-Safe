using System;

namespace ChildSafe
{
    class promoteQuote
    {
        private String[] quote_Vi =
        {
           "Chúng tôi tin rằng mọi người đều có quyền được an toàn trên mạng",
            "Đây chính là tương lai của an toàn mạng",
            "Bảo mật.. nhưng không làm chậm máy tính của bạn",
            "Giữ sự riêng tư và bảo mật danh tính cá nhân, tất cả trong một. Chưa bao giờ dễ thế!",
            "Tường lửa miễn phí là bước đầu của tự do trên mạng",
            "Đừng lo, có chúng tôi đây rồi!",
            "Chúng tôi bảo vệ sự riêng tư của bạn, giữ an toàn và bảo vệ dữ liệu cá nhân của bạn",
            "Đa thiết bị + riêng tư + bảo mật danh tính",
            "Đơn giản nhưng mạnh mẽ"

        };
        private String[] quote_En =
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
            if (lang == "Vi")
                return quote_Vi[randomNum.Next(quote_Vi.Length)]; // vietnamese quote
            else if (lang == "En")
                return quote_En[randomNum.Next(quote_En.Length)]; // english quote
            else
                return quote_En[randomNum.Next(quote_En.Length)]; // default quote language

        }
        public String getRandomQuote()
        {
            Random randomNum = new Random();
                return quote_En[randomNum.Next(quote_En.Length)]; // default quote language

        }
    }
}
