using UiPath.CodedWorkflows.DescriptorIntegration;

namespace _360DegreeTestSuiteDemo.ObjectRepository
{
    public static class Descriptors
    {
        public static class UiBank_Web
        {
            static string _reference = "ZnP3GeWE7kmww78Vun2Dlw/WLDpgzR9OUSkhMAtBQkgrA";
            public static _Implementation._UiBank_Web.__Form Form { get; private set; } = new _Implementation._UiBank_Web.__Form();
            public static _Implementation._UiBank_Web.__Home Home { get; private set; } = new _Implementation._UiBank_Web.__Home();
            public static _Implementation._UiBank_Web.__Quote Quote { get; private set; } = new _Implementation._UiBank_Web.__Quote();
            public static _Implementation._UiBank_Web.__Selection Selection { get; private set; } = new _Implementation._UiBank_Web.__Selection();
        }
    }
}

namespace _360DegreeTestSuiteDemo._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _UiBank_Web._Form
    {
        public class __Age : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Age(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/wrtBDPfNnUaIXELRq9uSeA", DisplayName = "Age", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Form
    {
        public class __Current_Yearly_Income : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Current_Yearly_Income(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/7AtUJF4DFUWoRy6oKDUG7Q", DisplayName = "Current Yearly Income", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Form
    {
        public class __Email_Address : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Email_Address(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/IpkMfjme0kqkC0Rcz8PHhg", DisplayName = "Email Address", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Form
    {
        public class __Loan_Amount_Requested : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Amount_Requested(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/SpwkRY_JhE2qsF_xymEgUA", DisplayName = "Loan Amount Requested", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Form
    {
        public class __Loan_Term : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Term(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/hqMNpz0HhkGyGwNAAjKb3g", DisplayName = "Loan Term", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Form
    {
        public class __Submit_Loan_Application : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Submit_Loan_Application(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/ei8YXED620GuR8sd8vkhFA", DisplayName = "Submit Loan Application", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web
    {
        public class __Form : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Form()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/g1zoloXgR0SGUbfa1WxB9w", DisplayName = "Form", Screen = this};
                Age = new _Implementation._UiBank_Web._Form.__Age(this, null);
                Current_Yearly_Income = new _Implementation._UiBank_Web._Form.__Current_Yearly_Income(this, null);
                Email_Address = new _Implementation._UiBank_Web._Form.__Email_Address(this, null);
                Loan_Amount_Requested = new _Implementation._UiBank_Web._Form.__Loan_Amount_Requested(this, null);
                Loan_Term = new _Implementation._UiBank_Web._Form.__Loan_Term(this, null);
                Submit_Loan_Application = new _Implementation._UiBank_Web._Form.__Submit_Loan_Application(this, null);
            }

            public _Implementation._UiBank_Web._Form.__Age Age { get; private set; }

            public _Implementation._UiBank_Web._Form.__Current_Yearly_Income Current_Yearly_Income { get; private set; }

            public _Implementation._UiBank_Web._Form.__Email_Address Email_Address { get; private set; }

            public _Implementation._UiBank_Web._Form.__Loan_Amount_Requested Loan_Amount_Requested { get; private set; }

            public _Implementation._UiBank_Web._Form.__Loan_Term Loan_Term { get; private set; }

            public _Implementation._UiBank_Web._Form.__Submit_Loan_Application Submit_Loan_Application { get; private set; }
        }
    }

    namespace _UiBank_Web._Home
    {
        public class __Credit_Cards : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Credit_Cards(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/3SxiUwmfd0mzcUI0gQE1sg", DisplayName = "Credit Cards", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Home
    {
        public class __Forgot_Your_Password : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Forgot_Your_Password(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/tN9tzZ6CDUuA65isSUcHpA", DisplayName = "Forgot Your Password", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Home
    {
        public class __Get_Started : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Get_Started(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/q83j9_u-vUGQcPcDzwM5Ag", DisplayName = "Get Started", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Home
    {
        public class __Loans : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loans(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/nR2_1wedEUy5QFF2cimfbQ", DisplayName = "Loans", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Home
    {
        public class __Login : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Login(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/OJeIZRt8Y0iKI8a86SiAtQ", DisplayName = "Login", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Home
    {
        public class __Mobile_Banking : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Mobile_Banking(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/cBMFh9pID0Sn4XlzBh_yog", DisplayName = "Mobile Banking", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Home
    {
        public class __Password : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Password(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/MbdwAEjXBkCv70m2MzDWFg", DisplayName = "Password", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Home
    {
        public class __Products : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Products(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/ylu_8IOLGEur1Wz0feCc1g", DisplayName = "Products", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Home
    {
        public class __Register_For_Account : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Register_For_Account(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/In1mYo0DAke6kODBq8keLQ", DisplayName = "Register For Account", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Home
    {
        public class __Sign_In : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Sign_In(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/7rIufOeI70CbjrPt_In7CA", DisplayName = "Sign In", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Home
    {
        public class __Username : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Username(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/_AiiGASExUuBgp-KEdnokg", DisplayName = "Username", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web
    {
        public class __Home : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Home()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/8Lw5m2-tLEG-qT1E9I0-Vw", DisplayName = "Home", Screen = this};
                Credit_Cards = new _Implementation._UiBank_Web._Home.__Credit_Cards(this, null);
                Forgot_Your_Password = new _Implementation._UiBank_Web._Home.__Forgot_Your_Password(this, null);
                Get_Started = new _Implementation._UiBank_Web._Home.__Get_Started(this, null);
                Loans = new _Implementation._UiBank_Web._Home.__Loans(this, null);
                Login = new _Implementation._UiBank_Web._Home.__Login(this, null);
                Mobile_Banking = new _Implementation._UiBank_Web._Home.__Mobile_Banking(this, null);
                Password = new _Implementation._UiBank_Web._Home.__Password(this, null);
                Products = new _Implementation._UiBank_Web._Home.__Products(this, null);
                Register_For_Account = new _Implementation._UiBank_Web._Home.__Register_For_Account(this, null);
                Sign_In = new _Implementation._UiBank_Web._Home.__Sign_In(this, null);
                Username = new _Implementation._UiBank_Web._Home.__Username(this, null);
            }

            public _Implementation._UiBank_Web._Home.__Credit_Cards Credit_Cards { get; private set; }

            public _Implementation._UiBank_Web._Home.__Forgot_Your_Password Forgot_Your_Password { get; private set; }

            public _Implementation._UiBank_Web._Home.__Get_Started Get_Started { get; private set; }

            public _Implementation._UiBank_Web._Home.__Loans Loans { get; private set; }

            public _Implementation._UiBank_Web._Home.__Login Login { get; private set; }

            public _Implementation._UiBank_Web._Home.__Mobile_Banking Mobile_Banking { get; private set; }

            public _Implementation._UiBank_Web._Home.__Password Password { get; private set; }

            public _Implementation._UiBank_Web._Home.__Products Products { get; private set; }

            public _Implementation._UiBank_Web._Home.__Register_For_Account Register_For_Account { get; private set; }

            public _Implementation._UiBank_Web._Home.__Sign_In Sign_In { get; private set; }

            public _Implementation._UiBank_Web._Home.__Username Username { get; private set; }
        }
    }

    namespace _UiBank_Web._Quote
    {
        public class __Apply_For_Another_Loan : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Apply_For_Another_Loan(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/Gip9aFdN6UyHM7UCxqParw", DisplayName = "Apply For Another Loan", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Quote
    {
        public class __Back_To_Loan_Center : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Back_To_Loan_Center(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/K2WqULbAckuaxZZotXBINA", DisplayName = "Back To Loan Center", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Quote
    {
        public class __Loan_Rate : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Rate(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/eRQb4xTQgEuMetkD0pINgg", DisplayName = "Loan Rate", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Quote
    {
        public class __Success_Message_1 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Success_Message_1(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/XwhAvkz3_kCTYhzX7fihsw", DisplayName = "Success Message 1", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Quote
    {
        public class __Success_Message_2 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Success_Message_2(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/Gr0rVfZuxUCCKtfxy30_TQ", DisplayName = "Success Message 2", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web
    {
        public class __Quote : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Quote()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/wk3V_FYp5k2IGq-8eRWM6Q", DisplayName = "Quote", Screen = this};
                Apply_For_Another_Loan = new _Implementation._UiBank_Web._Quote.__Apply_For_Another_Loan(this, null);
                Back_To_Loan_Center = new _Implementation._UiBank_Web._Quote.__Back_To_Loan_Center(this, null);
                Loan_Rate = new _Implementation._UiBank_Web._Quote.__Loan_Rate(this, null);
                Success_Message_1 = new _Implementation._UiBank_Web._Quote.__Success_Message_1(this, null);
                Success_Message_2 = new _Implementation._UiBank_Web._Quote.__Success_Message_2(this, null);
            }

            public _Implementation._UiBank_Web._Quote.__Apply_For_Another_Loan Apply_For_Another_Loan { get; private set; }

            public _Implementation._UiBank_Web._Quote.__Back_To_Loan_Center Back_To_Loan_Center { get; private set; }

            public _Implementation._UiBank_Web._Quote.__Loan_Rate Loan_Rate { get; private set; }

            public _Implementation._UiBank_Web._Quote.__Success_Message_1 Success_Message_1 { get; private set; }

            public _Implementation._UiBank_Web._Quote.__Success_Message_2 Success_Message_2 { get; private set; }
        }
    }

    namespace _UiBank_Web._Selection
    {
        public class __Already_Have_A_Loan : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Already_Have_A_Loan(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/aGmCQVX1kUWf2w06NoZ8FQ", DisplayName = "Already Have A Loan", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web._Selection
    {
        public class __Apply_For_A_Loan : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Apply_For_A_Loan(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/6UZssoLwe0O5WzxBXYrzWA", DisplayName = "Apply For A Loan", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web
    {
        public class __Selection : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Selection()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "ZnP3GeWE7kmww78Vun2Dlw/EsP28pCeNUWy0mBNgOUCwg", DisplayName = "Selection", Screen = this};
                Already_Have_A_Loan = new _Implementation._UiBank_Web._Selection.__Already_Have_A_Loan(this, null);
                Apply_For_A_Loan = new _Implementation._UiBank_Web._Selection.__Apply_For_A_Loan(this, null);
            }

            public _Implementation._UiBank_Web._Selection.__Already_Have_A_Loan Already_Have_A_Loan { get; private set; }

            public _Implementation._UiBank_Web._Selection.__Apply_For_A_Loan Apply_For_A_Loan { get; private set; }
        }
    }
}