# Autorest customization does not work.


### AutoRest Configuration
> see https://aka.ms/autorest
``` yaml
csharp: true
public-clients: true
output-folder: ./Generated
input-file: $(this-folder)/swagger.yaml
namespace: Core
output-artifact:
    - configuration.yaml
directive:
 from: swagger-document
 where: $.definitions.*
 transform: >
   $["x-accessibility"] = "public"
```

### Output
```
PS D:\Martin\autorest-customization> autorest .\readme.md
AutoRest code generation utility [cli version: 3.2.3; node: v12.18.3, max-memory: 2048 MB] (C) 2018 Microsoft Corporation. https://aka.ms/autorest                                                                                                                                                 
NOTE: AutoRest core version selected from configuration: ~3.1.0.
Loading AutoRest core      'C:\Users\trojan\.autorest\@autorest_core@3.1.3\node_modules\@autorest\core\dist' (3.1.3) INFORMATION: > Loading AutoRest extension '@autorest/csharp' (latest->3.0.0-beta.20210629.5)
INFORMATION: > Loading AutoRest extension '@autorest/modelerfour' (4.19.3->4.19.3)
WARNING (PreCheck/CheckDuplicateSchemas): Checking for duplicate schemas, this could take a (long) while.  Run with --verbose for more detail.
WARNING (Interpretations): Generating 'operationId' to 'Core' for 'get' operation on path '/Core/MessageBase' 
WARNING: output-folder path should be an absolute path
[6.59 s] Generation Complete
```
