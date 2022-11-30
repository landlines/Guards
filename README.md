# Guards

Simple .NET parameter guards.

### Usage

Guards can be configured for any input parameters via the static `Guard` class.
Guard checks can be chained together to perform complex validation. Custom
validation is supported as well. Validators set default error messages in thrown
exceptions but also accept custom error messages.

```#csharp
    public static bool HasUpperCase(string value)
    {
        return value.Any(char.IsUpper);
    }

    public static bool HasLowerCase(string value)
    {
        return value.Any(char.IsLower);
    }

    public static bool HasNumber(string value)
    {
        return value.Any(char.IsNumber);
    }

    public void SetUserPassword(long userId, string newPassword)
    {
        Guard.ThrowIf(nameof(newPassword), newPassword)
            .Null()
            .Empty()
            .Whitespace()
            .ShorterThan(8)
            .False(HasUpperCase)
            .False(HasLowerCase)
            .False(HasNumber);
        ...
    }
```

### Validation Methods

The methods listed below show the `message` argument, however each method
has an alternative without the `message` argument. Calling the alternative or
passing a `null` message with cause the validator to use the default error
messages.  

```#csharp
    public void Check(int a, int b, int c)
    {
        Guard.ThrowIf(nameof(a), a).LessThan(5);            // Uses default error
        Guard.ThrowIf(nameof(a), a).LessThan(5, null);      // Uses default error
        Guard.ThrowIf(nameof(a), a).LessThan(5, "Oh no!");  // Uses custom error
    }
```

- `array`
  - `LengthEqualTo(int len, string message)`
  - `LengthGreaterThan(int len, string message)`
  - `LengthGreaterThanOrEqualTo(int len, string message)`
  - `LengthLessThan(int len, string message)`
  - `LengthLessThanOrEqualTo(int len, string message)`
  - `LengthNotEqualTo(int len, string message)`
- `byte`
  - `EqualTo(byte val, string message)`
  - `Even(string message)`
  - `GreaterThan(byte val, string message)`
  - `GreaterThanOrEqualTo(byte val, string message)`
  - `Less(byte val, string message)`
  - `LessThanOrEqualTo(byte val, string message)`
  - `NotEqaul(byte val, string message)`
  - `Odd(string message)`
  - `Outside(string message, params byte[] set)`
  - `OutsideExclusiveRange(byte lowerBound, byte upperBound, string message)`
  - `OutsideInclusiveRange(byte lowerBound, byte upperBound, string message)`
  - `Within(string message, params byte[] set)`
  - `WithinExclusiveRange(byte lowerBound, byte upperBound, string message)`
  - `WithinInclusiveRange(byte lowerBound, byte upperBound, string message)`
- `DateTime`
  - `IsInFuture(string message)`
  - `IsInFutureUtc(string message)`
  - `IsInPast(string message)`
  - `IsInPastUtc(string message)`
- `int`, `long`, `short`
  - `EqualTo([int|long|short] val, string message)`
  - `Even(string message)`
  - `GreaterThan([int|long|short] val, string message)`
  - `GreaterThanOrEqualTo([int|long|short] val, string message)`
  - `LessThan([int|long|short] val, string message)`
  - `LessThanOrEqualTo([int|long|short] val, string message)`
  - `NotEqaul([int|long|short] val, string message)`
  - `Odd(string message)`
  - `Outside(string message, params [int|long|short][] set)`
  - `OutsideExclusiveRange([int|long|short] lowerBound, [int|long|short] upperBound, string message)`
  - `OutsideInclusiveRange([int|long|short] lowerBound, [int|long|short] upperBound, string message)`
  - `Within(string message, params [int|long|short][] set)`
  - `WithinExclusiveRange([int|long|short] lowerBound, [int|long|short] upperBound, string message)`
  - `WithinInclusiveRange([int|long|short] lowerBound, [int|long|short] upperBound, string message)`
- `Func` (custom)
  - `False(Func<T, bool> func, string message)`
  - `True(Func<T, bool> func, string message)`
- `object`
  - `Default(string message)`
  - `Null(string message)`
- `string`
  - `Empty(string message)`
  - `InvalidDomain(string message)`
  - `InvalidEmail(string message)`
  - `LongerThan(int len, string message)`
  - `ShorterThan(int len, string message)`
  - `Whitespace(string message)`
