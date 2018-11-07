# HW-6
Creating a web application that uses identity.

# Pick a vulnerability from the OWASP Top Ten (2017 edition is preferable) that we have not discussed in class. Explain it and how to use ASP.NET Core utilities to prevent it.

# Injection
Injection attacks happen when untrusted data is sent to a code interpreter through a form input or some other data submission to a web application. For example, an attacker could enter SQL database code into a form that expects a plaintext username. If that form input is not properly secured, this would result in that SQL code being executed. This is known as an SQL injection attack.

Injection attacks can be prevented by validating and/or sanitizing user-submitted data. (Validation means rejecting suspicious-looking data, while sanitization refers to cleaning up the suspicious-looking parts of the data.) In addition, a database admin can set controls to minimize the amount of information an injection attack can expose.

# Explain how passwords are stored in ASP.NET Core and how this relates to the concept of "Cryptographic Agility".
As the data protection needs the package related to microsoft ASP.NET.

This contains the cryptographic keys with the derivation functions which has no dependency on the data protection system and are independent completely.

The method Key Derivation helps to create the hashing of the password with the help of PBKDF2 algorithms.

There are 3 factors on which it resides.

Pbkdf2 method helps to support many/multiple PRFs,

It detects the operating systems version and chooses the efficient and optimized routes.

This also needs a caller for specifying the parameters.

# The Microsoft.AspNetCore.Identity defines the following domain classes. Please explain each:

# IdentityRole
    Identity role represent a role in a identity system. IdentityRole is the default implementation of IdentityRole<TKey> which uses a string as the primary key. 
    Ex: public class IdentityRole : Microsoft.AspNetCore.Identity.IdentityRole<string> 
    
# IdentityUserRole
    IdentityUserRole represent the relationship between a users and roles. The properties include Roleld-> gets or sets the primary key of the role that is linked to the user. UserId-> gets and sets the primary key of the user that is linked to a role. 
      Ex: public class IdentityUserRole<TKey> where TKey : IEquatable<TKey>
      
# IdentityUserClaim
    IdentityUserClaim represent a claim that a user possesses. The properties of IdentityUserClaim includes claimType, ClaimValue, Id, and userId. 
    Ex: public class IdentityUserClaim<TKey> where TKey : IEquatable<TKey>
    
# IdentityUserLogin
    Represent a login and its associated provider for user. Properties include LoginProvider-> gets or sets the login provider for the login. ProviderDisplayName-> gets or sets the friendly name used in a UI for the login. 
    Ex: public class IdentityUserLogin<TKey> where TKey : IEquatable<TKey>
    
# IdentityUserToken
    It represents an authentication token for a user. Properties include LoginProvider-> gets or sets the LoginProvider this token is form. and Name-> gets and sets the name of the token.
    Ex: public class IdentityUserToken<TKey> where TKey : IEquatable<TKey>
    
# IdentityRoleClaim
    It represent a claim that is granted to all users within a role. The properties includes ClaimType-> gets or sets the claim type for this claim. ClaimValue-> gets or sets the claim value for this claim. Id-> gets or sets the identifier for this role claim. Roleld-> gets or sets the of the primary key of the role associated with this claim. 
    Ex: public class IdentityRoleClaim<TKey> where TKey : IEquatable<TKey>
  
