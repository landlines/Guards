using System.Collections.Generic;

namespace Guards.Common
{
    internal enum MessageType
    {
        BriefEqual,
        BriefEven,
        BriefGreaterThan,
        BriefGreaterThanOrEqual,
        BriefLessThan,
        BriefLessThanOrEqual,
        BriefNotEqual,
        BriefOdd,
        BriefOutside,
        BriefOutsideExclusive,
        BriefOutsideInclusive,
        BriefWithin,
        BriefWithinExclusive,
        BriefWithinInclusive,
        CustomValidator,
        DateInFuture,
        DateInPast,
        Equal,
        Even,
        GreaterThan,
        GreaterThanOrEqual,
        LengthEqual,
        LengthGreaterThan,
        LengthGreaterThanOrEqual,
        LengthLessThan,
        LengthLessThanOrEqual,
        LengthNotEqual,
        LessThan,
        LessThanOrEqual,
        NotEqual,
        ObjectDefault, 
        ObjectNull,
        Odd,
        Outside,
        OutsideExclusive,
        OutsideInclusive,
        SimpleOutsideExclusive,
        SimpleOutsideInclusive,
        SimpleWithin,
        SimpleWithinExclusive,
        SimpleWithinInclusive,
        StringEmpty,
        StringInvalidDomain,
        StringInvalidEmail,
        StringLongerThan,
        StringShorterThan,
        StringWhitespace,
        Within,
        WithinExclusive,
        WithinInclusive,
        SimpleOutside,
    }

    internal static class Messages
    {
        // ...
        //
        // Brief error messages. Mostly used in the context of byte evaluations
        // to avoid unpredicatable string outputs.
        private const string BriefEq = "{0} cannot be equal to the compare value.";
        private const string BriefEven = "{0} cannot be even.";
        private const string BriefGt = "{0} cannot be greater than the compare value.";
        private const string BriefGte = "{0} cannot be greater than or equal to the compare value.";
        private const string BriefLt = "{0} cannot be less than the compare value.";
        private const string BriefLte = "{0} cannot be less than or equal to the compare value.";
        private const string BriefNeq = "{0} cannot be unequal to the compare value.";
        private const string BriefOdd = "{0} cannot be odd.";
        private const string BriefOutside = "{0} cannot be outside the set of compare values.";
        private const string BriefOutsideEx = "{0} cannot be outside the set of exclusive compare values.";
        private const string BriefOutsideIn = "{0} cannot be outside the set of inclusive compare values.";
        private const string BriefWithin = "{0} cannot be within the set of compare values.";
        private const string BriefWithinEx = "{0} cannot be within the set of exclusive compare values.";
        private const string BriefWithinIn = "{0} cannot be within the set of inclusive compare values.";

        private const string Custom = "{0} failed a custom validator.";
        
        private const string DateInFuture = "{0} cannot be in the future; was {1}.";
        private const string DateInPast = "{0} cannot be in the past; was {1}.";

        private const string Eq = "{0} cannot equal {1}.";
        private const string Even = "{0} cannot be even; was {1}.";
        private const string Gt = "{0} cannot be greater than {1}; was {2}.";
        private const string Gte = "{0} cannot be greater than or equal to {1}; was {2}";
        private const string LengthEq = "The length of {0} cannot be equal to {1}; was {2}.";
        private const string LengthGt = "The length of {0} cannot be greater than {1}; was {2}.";
        private const string LengthGte = "The length of {0} cannot be greater than or equal to {1}; was {2}.";
        private const string LengthLt = "The length of {0} cannot be less than {1}; was {2}.";
        private const string LengthLte = "The length of {0} cannot be less than or equal to {1}; was {2}.";
        private const string LengthNeq = "The length of {0} cannot be unequal to {1}; was {2}.";
        private const string Lt = "{0} cannot be less than {1}; was {2}.";
        private const string Lte = "{0} cannot be less than or equal to {1}; was {2}.";
        private const string Neq = "{0} cannot be unequal to {1}; was {2}.";

        private const string ObjectDefault = "{0} cannot be a default value.";
        private const string ObjectNull = "{0} cannot be null.";
        
        private const string Odd = "{0} cannot be odd; was {1}.";
        private const string Outside = "{0} cannot be outside the range [{1}]; was {2}.";
        private const string OutsideEx = "{0} cannot be outside the exclusive range [{1}]; was {2}.";
        private const string OutsideIn = "{0} cannot be outside the inclusive range [{1}]; was {2}.";
        
        // ...
        // 
        // Simplified inclusive / exclusive error messages
        private const string SimpleOutside = "{0} cannot be outside the range {1} - {2}; was {3}.";
        private const string SimpleOutsideEx = "{0} cannot be outside the exclusive range {1} - {2}; was {3}.";
        private const string SimpleOutsideIn = "{0} cannot be outside the inclusive range {1} - {2}; was {3}.";
        private const string SimpleWithin = "{0} cannot be within the range {1} - {2}; was {3}.";
        private const string SimpleWithinEx = "{0} cannot be within the exclusive range {1} - {2}; was {3}.";
        private const string SimpleWithinIn = "{0} cannot be within the inclusive range {1} - {2}; was {3}.";

        private const string StringEmpty = "{0} cannot be an empty string.";
        private const string StringInvalidDomain = "{0} is not a valid domain.";
        private const string StringInvalidEmail = "{0} is not a valid email.";
        private const string StringLongerThan = "{0} cannot be longer than {1}; was {2}.";
        private const string StringShorterThan = "{0} cannot be shorter than {1}; was {2}.";
        private const string StringWhitespace = "{0} cannot be whitspace.";
        
        private const string Within = "{0} cannot be within the range [{1}]; was {2}.";
        private const string WithinEx = "{0} cannot be within the exclusive range [{1}]; was {2}.";
        private const string WithinIn = "{0} cannot be within the inclusive range [{1}]; was {2}.";

        private static readonly IDictionary<MessageType, string> MessageMap = new Dictionary<MessageType, string>
        {
            { MessageType.BriefEqual, BriefEq }, 
            { MessageType.BriefEven, BriefEven },
            { MessageType.BriefGreaterThan, BriefGt }, 
            { MessageType.BriefGreaterThanOrEqual, BriefGte },
            { MessageType.BriefLessThan, BriefLt }, 
            { MessageType.BriefLessThanOrEqual, BriefLte },
            { MessageType.BriefNotEqual, BriefNeq }, 
            { MessageType.BriefOdd, BriefOdd },
            { MessageType.BriefOutside, BriefOutside }, 
            { MessageType.BriefOutsideExclusive, BriefOutsideEx },
            { MessageType.BriefOutsideInclusive, BriefOutsideIn },
            { MessageType.BriefWithin, BriefWithin }, 
            { MessageType.BriefWithinExclusive, BriefWithinEx },
            { MessageType.BriefWithinInclusive, BriefWithinIn }, 
            { MessageType.CustomValidator, Custom },
            { MessageType.DateInFuture, DateInFuture },
            { MessageType.DateInPast, DateInPast }, 
            { MessageType.Equal, Eq },
            { MessageType.Even, Even }, 
            { MessageType.GreaterThan, Gt },
            { MessageType.GreaterThanOrEqual, Gte }, 
            { MessageType.LengthEqual, LengthEq },
            { MessageType.LengthGreaterThan, LengthGt }, 
            { MessageType.LengthGreaterThanOrEqual, LengthGte },
            { MessageType.LengthLessThan, LengthLt }, 
            { MessageType.LengthLessThanOrEqual, LengthLte },
            { MessageType.LengthNotEqual, LengthNeq }, 
            { MessageType.LessThan, Lt },
            { MessageType.LessThanOrEqual, Lte }, 
            { MessageType.NotEqual, Neq },
            { MessageType.ObjectDefault, ObjectDefault},
            { MessageType.ObjectNull, ObjectNull },
            { MessageType.Odd, Odd }, 
            { MessageType.Outside, Outside },
            { MessageType.OutsideExclusive, OutsideEx }, 
            { MessageType.OutsideInclusive, OutsideIn },
            { MessageType.Within, Within }, 
            { MessageType.WithinExclusive, WithinEx },
            { MessageType.WithinInclusive, WithinIn },
            { MessageType.SimpleOutside, SimpleOutside },
            { MessageType.SimpleOutsideExclusive, SimpleOutsideEx },
            { MessageType.SimpleOutsideInclusive, SimpleOutsideIn },
            { MessageType.SimpleWithin, SimpleWithin },
            { MessageType.SimpleWithinExclusive, SimpleWithinEx },
            { MessageType.SimpleWithinInclusive, SimpleWithinIn },
            { MessageType.StringEmpty, StringEmpty },
            { MessageType.StringInvalidDomain, StringInvalidDomain },
            { MessageType.StringInvalidEmail, StringInvalidEmail},
            { MessageType.StringLongerThan, StringLongerThan },
            { MessageType.StringShorterThan, StringShorterThan },
            { MessageType.StringWhitespace, StringWhitespace },
        };

        public static string GetMessage(MessageType @type)
        {
            return MessageMap.TryGetValue(@type, out string message) == false
                ? "Incorrect value for {0}; was {1}"
                : message;
        }
    }

    internal static class ErrorFormatter
    {
        private static string FormatMessage(string message, params object[] values)
        {
            return string.Format(message, values);
        }

        public static string GetDefaultMessage(MessageType messageType, params object[] values)
        {
            return FormatMessage(Messages.GetMessage(messageType), values);
        }
    }
}