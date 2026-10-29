---
id: design-system
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [code-reviewer, a11y, bundle-budget, visual-regression]
---

# design-system — generated UI uses the project's design system

## Rule

Any change that produces or modifies UI follows `.agent/design.md`:

- Use a token. Never a literal colour, spacing value, radius, or font size where a
  token exists.
- Reuse before creating. Check the component inventory; a near-match plus a prop beats
  a new component.
- A new component variant requires an ADR. Three button variants existing means a
  fourth is a design decision, not an implementation detail.
- Every interactive element has a visible focus state.
- Both themes, where the project has two. A colour defined in only one is a bug.
- Respect `prefers-reduced-motion`.
- Meet the stated contrast target.

Where `design.md` does not exist because no design system was found, this policy is
not generated. It is never generated against an invented system.

## Why

An agent writing UI without the design system produces code that works and looks
wrong: a slightly different blue, 13px of padding, a fourth button variant. Each
instance is cheap to write, invisible to every functional gate, and expensive to
unpick once it has spread.

Design drift is also the one quality problem users see directly.

## Enforced by

- `code-reviewer` receives `design.md` on any UI diff and checks literals, new
  variants, focus states, single-theme colours, and off-scale spacing
- The `a11y` gate covers contrast and focus mechanically
- `bundle-budget` catches a new UI dependency added to avoid reuse
- `visual-regression` catches unintended visual change
- Rules with no gate are marked `manual` in `design.md`, so nobody mistakes
  reviewer-checked for enforced

## Violation

Replace the literal with its token. If no token fits, that is a design-system gap:
add the token — which is an ADR — rather than working around it with a literal. Record
the value under **Drift** in `design.md` if it must stay for now.
