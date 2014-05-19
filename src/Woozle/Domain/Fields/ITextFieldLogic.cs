﻿using System.Collections.Generic;
using Woozle.Model.SessionHandling;

namespace Woozle.Domain.Fields
{
    public interface ITextFieldLogic
    {
        IEnumerable<TextFieldSearchResult> GetTextFields(SessionData session);
        TextFieldSearchResult GetTextField(string name, SessionData session);
    }
}