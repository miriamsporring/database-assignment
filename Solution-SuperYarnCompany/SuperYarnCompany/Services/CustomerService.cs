using SuperYarnCompany.Entities;
using SuperYarnCompany.Models;
using SuperYarnCompany.Repositories;

namespace SuperYarnCompany.Services;

internal class CustomerService
{
    private readonly AddressRepository _addressRepository;
    private readonly CustomerTypeRepository _customerTypeRepository;
    private readonly CustomerRepository _customerRepository;

    public CustomerService(AddressRepository addressRepository, CustomerTypeRepository customerTypeRepository, CustomerRepository customerRepository)
    {
        _addressRepository = addressRepository;
        _customerTypeRepository = customerTypeRepository;
        _customerRepository = customerRepository;
    }

    // CREATE
    public async Task<bool> CreateCustomerAsync(CustomerRegistrationForm form)
    {
        if (!await _customerRepository.ExistsAsync(x => x.Email == form.Email))
        {
            // get or create address
            var addressEntity = await _addressRepository.GetAsync(x => x.StreetName == form.StreetName);
            addressEntity ??= await _addressRepository.CreateAsync(new AddressEntity { StreetName = form.StreetName, StreetNumber = form.StreetNumber, PostalCode = form.PostalCode, City = form.City });

            // get or create customer type
            var customerTypeEntity = await _customerTypeRepository.GetAsync(x => x.TypeName == form.CustomerType);
            customerTypeEntity ??= await _customerTypeRepository.CreateAsync(new CustomerTypeEntity { TypeName = form.CustomerType });

            var customerEntity = await _customerRepository.CreateAsync(new CustomerEntity()
            {
                FirstName = form.FirstName,
                LastName = form.LastName,
                CustomerTypeId = customerTypeEntity.Id,
                Email = form.Email,
                AddressId = addressEntity.Id

            });

            if (customerEntity != null)
            {
                return true;
            }
           
        }
        return false;

    }

    public async Task<bool> GetCustomerAsync(CustomerRegistrationForm form)

    {
       if(!await _customerRepository.ExistsAsync(x => x.Email == form.Email))
        {
            var addressEntity = await _addressRepository.GetAsync(x => x.StreetName == form.StreetName || x.PostalCode ==form.PostalCode);
        }
       return true;

    }



    //public async Task<CustomerEntity> UpdateCustomerAsync(CustomerEntity customerEntity)
    //{

    //}

    //public async Task<bool> DeleteCustomerAsync(string email)
    //{

    //}

}


//public async Task<CustomerEntity> CreateCustomerAsync(CustomerEntity customerEntity)
//{
//    // get or create address
//    var addressEntity = await _addressRepository.GetAsync(x => x.StreetName == customerEntity.Address.StreetName);
//    addressEntity ??= await _addressRepository.CreateAsync(new AddressEntity { StreetName = customerEntity.Address.StreetName, StreetNumber = customerEntity.Address.StreetNumber, PostalCode = customerEntity.Address.PostalCode, City = customerEntity.Address.City });

//    // get or create customer type
//    var customerTypeEntity = await _customerTypeRepository.GetAsync(x => x.TypeName == customerEntity.CustomerType.TypeName);
//    customerTypeEntity ??= await _customerTypeRepository.CreateAsync(new CustomerTypeEntity { TypeName = customerEntity.CustomerType.TypeName });

//    customerEntity.AddressId = addressEntity.Id;
//    customerEntity.CustomerTypeId = customerTypeEntity.Id;

//    // create customer
//    return await _customerRepository.CreateAsync(customerEntity);

//}
