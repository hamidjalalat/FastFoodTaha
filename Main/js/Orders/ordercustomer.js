﻿
Vue.filter("formatNumber", function (value) {
    return separate(value);
});

var app = new Vue({

    el: "#app",
    data: {
        breadPrice: null,
        selectedGroupProductId: null,
        listProduct: null,
        groupList: null,
        selectionProduct: [],
        description:null,
    }, 
    methods: {

     
        //redirectToAction() {
        //    let result=  $.post('/RegisterOrder/FirstCheck', { jsonOrder: JSON.stringify(this.selectionProduct), description: this.description });
        //    console.log(result)
        //    alert(result.readyState)

        //    window.location.href = "/RegisterOrder/SecondCheck";

        //},

        redirectToAction() {
          let  parameter = { jsonOrder: JSON.stringify(this.selectionProduct), description: this.description };
            axios.post('/RegisterOrder/FirstCheck', parameter)
             .then(response => {

                 if(response.data)
                 {
                     window.location.href = "/RegisterOrder/SecondCheck";
                 }
     
     })
     .catch(error => {

         console.error(error)

     })
     .finally(() => {

     })

        },
    
        getAddProduct: function (item) {
            let itemGlobal = { Id: item.Id, Name: item.Name, Price: item.Price, count: item.count, hasBread: item.hasBread,Image_url:item.Image_url,Description:item.Description};
            
            if (itemGlobal.hasBread == true) {
                itemGlobal.Price += parseInt(this.breadPrice);
                itemGlobal.Name +=  "  با نان اضافه  "
            } 


            let has = true;
            this.selectionProduct.forEach(i => {

                if (i.Id == itemGlobal.Id && itemGlobal.hasBread == i.hasBread ) {
                    has = false;
                    i.count++;
                }

            });
            if (has) {

                this.selectionProduct.push(itemGlobal);

            }
       
            document.cookie = "listProduct=" + JSON.stringify(this.selectionProduct);
        },

        plus: function (item) {
            item.count++;
            
            document.cookie = "listProduct=" + JSON.stringify(this.selectionProduct);
        },

        minus: function (item) {

            if (item.count > 1) {

                item.count--

            }
            else
            {
                const index = this.selectionProduct.indexOf(item);
                if (index > -1) {
                    this.selectionProduct.splice(index, 1);
                }
            }
            
            document.cookie = "listProduct=" + JSON.stringify(this.selectionProduct);

        },

        getSubTotal: function (item) {
            let result =
                item.count * item.Price

            return result
        },

        getTotal: function () {

            let total = 0

            for (let index = 0; index < this.selectionProduct.length; index++) {

                let currentItem = this.selectionProduct[index]

                total +=
                    this.getSubTotal(currentItem)

            }
            this.selectionProduct.Total = total;
            return separate( total)

        },

    },
    computed: {
   
   
    },

    created: function () {
        let jsonlistProduct = getCookie('listProduct');
        if (jsonlistProduct != null) {
            this.selectionProduct = JSON.parse(jsonlistProduct);
        }
     
    },
      mounted() {
     
          axios.post('/Order/GetListProduct')
              .then(response => {

                  this.listProduct = response.data.listProduct;
                  this.groupList = response.data.listGruopProduct;
                  
                  for (let index = 0; index < this.listProduct.length; index++) {
                      Vue.set(this.listProduct[index], `hasBread`, false)
                      Vue.set(this.listProduct[index], `count`, 1)

                  }
              })
              .catch(error => {

                  console.error(error)

              })
              .finally(() => {

              })

          let parmeters = {name:'non'};
          axios.post('/Configs/GetConfig', parmeters)
              .then(response => {
                  this.breadPrice = response.data.Value;
                 
              })
              .catch(error => {

                  console.error(error)

              })
              .finally(() => {

              })
    }
})
