Feature: Newton API Calculations
    In order to verify the Newton API across various endpoints
    As a math enthusiast
    I want to perform different mathematical operations and validate the results

Scenario Outline: Perform mathematical operations via Newton API
    Given I have access to the Newton API
    When I call the '<operation>/<coded expression>' endpoint
    Then the responce should contain operation:'<operation>',expression:'<expression>',result:'<result>'

Examples: 
    | expression | coded expression | result        | operation |
    | x+x        | x%2Bx            | 2 x           | simplify  |
    | x^2+2x     | x%5E2%2B2x       | x (x + 2)     | factor    |
    | x^2+2x     | x%5E2%2B2x       | 2 x + 2       | derive    |
    | x^2+2x     | x%5E2%2B2x       | 1/3 x^3 + x^2 | integrate |
    | 2/x^3      | 2%7Cx%5E3        | 12 x + -16    | tangent   |
    | 2:4/x^3    | 2:4%7Cx%5E3      | 60            | area      |
    | 2/8        | 2%7C8            | 3             | log       |
