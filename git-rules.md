# Git Rules

## Commit Message Standards

Consistent commit messages help maintain a clear project history and facilitate automated changelog generation. All commit messages should follow this format:

```text
<type>(<scope>): <subject>

<body>

<footer>
```

### Types

- **feat**: A new feature
- **fix**: A bug fix
- **docs**: Documentation changes
- **style**: Changes that don't affect code functionality (formatting, missing semi-colons, etc.)
- **refactor**: Code changes that neither fix a bug nor add a feature
- **perf**: Performance improvements
- **test**: Adding or correcting tests
- **chore**: Changes to build process, auxiliary tools, libraries, etc.

### Scope

The scope should specify the component or module affected by the change (e.g., api, auth, database).

### Subject

- Use imperative, present tense: "add" not "added" or "adds"
- Don't capitalize the first letter
- No period at the end
- Keep it under 50 characters

### Body

- Use imperative, present tense
- Include motivation for the change
- Contrast with previous behavior
- Wrap at 72 characters

### Footer

- Reference issues and pull requests using specific prefixes to differentiate between them:
  - For issues: `Resolves #123`, `Fixes #123`, `Closes #123`
  - For pull requests: `Related to PR #456`, `See PR #456`
- Note breaking changes with `BREAKING CHANGE:`

### Reference Prefixes

Use these prefixes to clearly distinguish between issues and pull requests:

| Type          | Prefixes                      | Example              |
| ------------- | ----------------------------- | -------------------- |
| Issues        | `Fixes`, `Resolves`, `Closes` | `Fixes #123`         |
| Pull Requests | `Related to PR`, `See PR`     | `Related to PR #456` |

GitHub and most Git platforms will automatically link these references to the corresponding issues or pull requests when using the appropriate format.

### Examples

```text
feat(auth): add multi-factor authentication

Implement TOTP-based second factor for enhanced security.
Includes new user settings page for MFA configuration.

Resolves #123
Related to PR #456
```

```text
fix(api): correct pagination in search results

Search results were not properly paginated when the result set
exceeded 100 items, causing incomplete data returns.

Fixes #456
See PR #789
```

## Branch Naming Convention

All branch names should follow this pattern:

```text
<type>/<issue-number>-<short-description>
```

- **type**: Same as commit types (feat, fix, docs, etc.)
- **issue-number**: The related issue number
- **short-description**: Brief description using kebab-case

Examples:

- `feat/123-add-user-authentication`
- `fix/456-correct-pagination-bug`
- `docs/789-update-api-documentation`
