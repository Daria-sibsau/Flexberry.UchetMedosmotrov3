import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  номер: DS.attr('number'),
  классВредФакт: DS.belongsTo('i-i-s-uchet-medosmotrov3-класс-вред-факт', { inverse: null, async: false }),
  индНапрМедосм: DS.belongsTo('i-i-s-uchet-medosmotrov3-инд-напр-медосм', { inverse: 'вреднФактПроиз', async: false })
});

export let ValidationRules = {
  номер: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov3-вредн-факт-произ.validations.номер.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  классВредФакт: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov3-вредн-факт-произ.validations.классВредФакт.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  индНапрМедосм: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov3-вредн-факт-произ.validations.индНапрМедосм.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ВреднФактПроизE', 'i-i-s-uchet-medosmotrov3-вредн-факт-произ', {
    номер: attr('Номер', { index: 0 }),
    классВредФакт: belongsTo('i-i-s-uchet-medosmotrov3-класс-вред-факт', 'Вредные факторы', {
      наименование: attr('Наименование', { index: 2, hidden: true })
    }, { index: 1, displayMemberPath: 'наименование' })
  });
};
