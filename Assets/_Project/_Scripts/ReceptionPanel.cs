using System;
using System.Collections.Generic;
using System.Linq;
using _Project._Scripts;
using _Project._Scripts.DTO;
using _Project._Scripts.WebServices;
using TMPro;
using UnityEngine;

public class ReceptionPanel : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _measurementUnitDropdown;
    [SerializeField] private TMP_Dropdown _proudctTypeDropdown;
    [SerializeField] private TMP_Dropdown _proudctDropdown;
    [SerializeField] private TMP_InputField _productNameInputField;
    [SerializeField] private TMP_InputField _invoiceInputField;
    [SerializeField] private TMP_InputField _quantityInputField;
    [SerializeField] private HttpTest _httpTest;

    private async void Start()
    {
        var measurementUnits = await _httpTest.GetTypes(UrlGet.MeasurementUnits());
        var productType = await _httpTest.GetTypes(UrlGet.ProductType());

       

        _measurementUnitDropdown.AddAll(measurementUnits);
        _proudctTypeDropdown.AddAll(productType);
    }
}

public static class TMP_DropdownExtension
{
    public static TMP_Dropdown AddAll(this TMP_Dropdown dropdown,IEnumerable<WithNameDto> types)
    {
        dropdown.options.Clear();

        foreach (var result in types.Select(t => new TMP_Dropdown.OptionData(t.Name)))
        {
            dropdown.options.Add(result);
        }

        return dropdown;
    }
}
