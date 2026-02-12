# Extension

## Projects

### Extension.Tool.Services (Infrastructure)

**Purpose:** Provides core utility services and extension methods for the Extension.Tool solution.

#### StringExtension Class

**Purpose:** Provides extension methods for string operations to enhance string manipulation capabilities.

- **ToRemoveWhiteSpace()**: Removes all whitespace characters (spaces, tabs, newlines, etc.) from a string, returning a new string without any whitespace. Returns `null` if the input string is `null`.
  - **Usage:** `"ABC JBJH".ToRemoveWhiteSpace()` returns `"ABCJBJH"`

### Extension.Tool.Test

**Purpose:** Contains unit tests for validating the functionality of the Extension.Tool.Services project using the NUnit testing framework.
