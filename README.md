# Azure Solution Blueprint - Payment processing solution for PCI DSS enablement 


## Description
  


The Azure blueprint solution is intended to simplify azure adoption, showcase commonly used reference architecture, and teach how to deploy a secure and compliant PaaS solution for customer considering the complexities of storing sensitive payment card related data. 


## Documentation
All documentation is now avalible on docs.microsoft.com and can be accessed via https://docs.microsoft.com/en-us/azure/security/develop/

## Prerequisites
Install Powershell 5.2 version to execute the above scripts.
Install VS 2019 to create the web app.
Install Git on your system. Git is used to clone the source code locally.

## Deploy this solution
This Azure Security and Compliance Blueprint Automation is comprised of JSON configuration files and PowerShell scripts that are handled by Azure Resource Manager's API service to deploy resources within Azure. Detailed deployment instructions are available here.


1. Review 0-Setup-AdministrativeAccountAndPermission.md and run the provided commands.

2. Deploy a test solution with Contoso sample data or pilot an initial production environment.

      1A-ContosoWebStoreDemoAzureResources.ps1
          This script deploys Azure resources for a demonstration of a webstore using Contoso sample data.

# ACKNOWLEDGMENTS and DISCLAIMER


*July 2019*

*This document is for informational purposes only. MICROSOFT MAKE NO WARRANTIES, EXPRESS, IMPLIED, OR STATUTORY, AS TO THE INFORMATION IN THIS DOCUMENT. This document is provided “as-is.” Information and views expressed in this document, including URL and other Internet website references, may change without notice. Customers reading this document bear the risk of using it.*
*This document does not provide customers with any legal rights to any intellectual property in any Microsoft solutions.* 
*Customers may copy and use this document for their internal, reference purposes.*
*NOTE: Certain recommendations in this paper may result in increased data, network, or compute resource usage in Azure, and may increase a customer’s Azure license or subscription costs.*
*The solution in this document is intended as a reference architecture pilot and should not be used as-is for production purposes.  Achieving PCI compliance requires that customers consult with their Qualified Security Assessor.*

*This solution was developed cooperatively by Microsoft*


### Authors of the document 

* *Feroskhan Hasenkhan (Microsoft)*
















  
