using SuperYarnCompany.Context;
using SuperYarnCompany.Entities;
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

    public async Task<CustomerEntity> CreateCustomerAsync(CustomerEntity customerEntity)
    {
        // get or create address
        var addressEntity = await _addressRepository.GetAsync(x => x.StreetName == customerEntity.Address.StreetName);
        addressEntity ??= await _addressRepository.CreateAsync(new AddressEntity { StreetName = customerEntity.Address.StreetName, StreetNumber = customerEntity.Address.StreetNumber, PostalCode = customerEntity.Address.PostalCode, City = customerEntity.Address.City});

        // get or create customer type
        var customerTypeEntity = await _customerTypeRepository.GetAsync(x => x.TypeName == customerEntity.CustomerType.TypeName);
        customerTypeEntity ??= await _customerTypeRepository.CreateAsync(new CustomerTypeEntity { TypeName = customerEntity.CustomerType.TypeName });

        customerEntity.AddressId = addressEntity.Id;
        customerEntity.CustomerTypeId = customerTypeEntity.Id;

        // create customer
        return await _customerRepository.CreateAsync(customerEntity);

    }

    //public async Task<CustomerEntity> GetCustomerAsync(string email) //se dagens inspelning 15/11
    //{

    //}

    //public async Task<CustomerEntity> UpdateCustomerAsync(CustomerEntity customerEntity)
    //{

    //}

    //public async Task<bool> DeleteCustomerAsync(string email)
    //{

    //}

}
