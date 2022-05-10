1. What is the difference between Component and PureComponent? give an example where it might break my app.
A: Component you can cancel the action of re-render current component, in PureComponent we don't have it.
Places where we should optimize and improve our rendering time, sometimes we can control it for not break it.

2. Context + ShouldComponentUpdate might be dangerous. Can think of why is that?
A: Because you can have multiple places to control causing hude side effects.

3. Describe 3 ways to pass information from a component to its PARENT.
A: Props based on functions, dispatching RxJS events, Context with functions inside

4. Give 2 ways to prevent components from re-rendering.
A: I only know one - based on life cycle shouldComponentUpdate we can perform next or not based on a specific rule.

5. What is a fragment and why do we need it? Give an example where it might break my app.
A: It's a piece of code that will not be render or affect our DOM. Imagine that we have a <TR> and next component should be a <TD> based on HTML Semantics - if we don't have Fragments we will have to insert a wrong element between <TR> and <TD>.

6. Give 3 examples of the HOC pattern.
A: -

7. what's the difference in handling exceptions in promises, callbacks and async...await.
A: Handling exceptions in Promises we use RESOLVE and REJECT parameters, callbacks we can create how many parameter functions we need, and async....await is designed to future action/operation that will happen (Promise for example)

8. How many arguments does setState take and why is it async.
A: 2, because it happens as a FIFO concept to all asked changes (queue)

9. List the steps needed to migrate a Class to Function Component.
A: Lifecycle, Data flow, Hooks

10. List a few ways styles can be used with components.
A: CSS, Styled Components or even HTML attributes

11. How to render an HTML string coming from the server.
A: with string interpolation, or when it's ref object you can use innerHTML as a basic DOM
