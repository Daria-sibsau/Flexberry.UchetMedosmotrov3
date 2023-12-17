import EditFormController from 'ember-flexberry/controllers/edit-form';

export default EditFormController.extend({
  parentRoute: 'i-i-s-uchet-medosmotrov3-инд-напр-медосм-l',

  getCellComponent(attr, bindingPath, model) {
    let cellComponent = this._super(...arguments);
    if (attr.kind === 'belongsTo') {
      switch (`${model.modelName}+${bindingPath}`) {
        case 'i-i-s-uchet-medosmotrov3-вредн-факт-произ+классВредФакт':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'наименование',
            required: true,
            relationName: 'классВредФакт',
            projection: 'КлассВредФактL',
            autocomplete: true,
          };
          break;

      }
    }

    return cellComponent;
  },
});
