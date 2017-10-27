﻿using Atata;

namespace AtataSampleApp.AutoTests
{
    using _ = HomePage;

    [VerifyTitle(Title, Format = null)]
    [VerifyH1(Title)]
    [VerifyContent("Lorem ipsum")]
    public class HomePage : AppPage<_>
    {
        public const string Title = "Atata Sample App";

        [FindById]
        public Link<SignInPage, _> SignIn { get; private set; }

        [FindById]
        public Link<SignUpPage, _> SignUp { get; private set; }
    }
}
