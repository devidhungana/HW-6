# HW-6
Creating a web application that uses identity.

# Pick a vulnerability from the OWASP Top Ten (2017 edition is preferable) that we have not discussed in class. Explain it and how to use ASP.NET Core utilities to prevent it.

# Injection
Injection attacks happen when untrusted data is sent to a code interpreter through a form input or some other data submission to a web application. For example, an attacker could enter SQL database code into a form that expects a plaintext username. If that form input is not properly secured, this would result in that SQL code being executed. This is known as an SQL injection attack.

Injection attacks can be prevented by validating and/or sanitizing user-submitted data. (Validation means rejecting suspicious-looking data, while sanitization refers to cleaning up the suspicious-looking parts of the data.) In addition, a database admin can set controls to minimize the amount of information an injection attack can expose.

# Explain how passwords are stored in ASP.NET Core and how this relates to the concept of "Cryptographic Agility".


# The Microsoft.AspNetCore.Identity defines the following domain classes. Please explain each:

IdentityRole
IdentityUserRole
IdentityUserClaim
IdentityUserLogin
IdentityUserToken
IdentityRoleClaim
