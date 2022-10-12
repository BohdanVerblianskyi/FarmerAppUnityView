using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace _Project._Scripts
{
    public class DropdownService : MonoBehaviour
    {
        [SerializeField] private TMP_Dropdown _dropdown;
        [SerializeField] private HttpTest _httpTest;
        
        private async void Start()
        {
            var typeDtos = await _httpTest.Get();

            _dropdown.options.Clear();
            foreach (var optionData in typeDtos.Select(t => new TMP_Dropdown.OptionData(t.Name)))
            {
                _dropdown.options.Add(optionData);
            }
            
            _dropdown.onValueChanged.AddListener(d => Debug.Log(_dropdown.options[d].text));
        }

        private void Drow()
        {
            throw new NotImplementedException();
        }
    }
}