import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  дата: DS.attr('date', { defaultValue() { return new Date(); } }),
  медУчреждение: DS.attr('string'),
  номерДок: DS.attr('number'),
  организация: DS.belongsTo('i-i-s-uchet-medosmotrov3-организация', { inverse: null, async: false }),
  сотрудники: DS.belongsTo('i-i-s-uchet-medosmotrov3-сотрудники', { inverse: null, async: false }),
  вреднФактПроиз: DS.hasMany('i-i-s-uchet-medosmotrov3-вредн-факт-произ', { inverse: 'индНапрМедосм', async: false })
});

export let ValidationRules = {
  дата: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov3-инд-напр-медосм.validations.дата.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  медУчреждение: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov3-инд-напр-медосм.validations.медУчреждение.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  номерДок: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov3-инд-напр-медосм.validations.номерДок.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  организация: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov3-инд-напр-медосм.validations.организация.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  сотрудники: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov3-инд-напр-медосм.validations.сотрудники.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  вреднФактПроиз: {
    descriptionKey: 'models.i-i-s-uchet-medosmotrov3-инд-напр-медосм.validations.вреднФактПроиз.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ИндНапрМедосмE', 'i-i-s-uchet-medosmotrov3-инд-напр-медосм', {
    номерДок: attr('Номер документа', { index: 0 }),
    дата: attr('Дата', { index: 1 }),
    организация: belongsTo('i-i-s-uchet-medosmotrov3-организация', 'Организация', {
      наименование: attr('Наименование', { index: 3, hidden: true })
    }, { index: 2, displayMemberPath: 'наименование' }),
    медУчреждение: attr('Медицинское учреждение', { index: 4 }),
    сотрудники: belongsTo('i-i-s-uchet-medosmotrov3-сотрудники', 'Сотрудники', {
      iDСотрудника: attr('ID сотрудника', { index: 6, hidden: true }),
      фИО: attr('ФИО', { index: 7, hidden: true }),
      датаРождения: attr('Дата рождения', { index: 8 }),
      должности: belongsTo('i-i-s-uchet-medosmotrov3-должности', '', {
        наименование: attr('Должность', { index: 9 }),
        подразделения: belongsTo('i-i-s-uchet-medosmotrov3-подразделения', '', {
          наименование: attr('Подразделение', { index: 10 })
        }, { index: -1, hidden: true })
      }, { index: -1, hidden: true })
    }, { index: 5, displayMemberPath: 'фИО' }),
    вреднФактПроиз: hasMany('i-i-s-uchet-medosmotrov3-вредн-факт-произ', 'Вредные факторы производства', {
      номер: attr('Номер', { index: 0 }),
      классВредФакт: belongsTo('i-i-s-uchet-medosmotrov3-класс-вред-факт', 'Вредные факторы', {
        наименование: attr('Наименование', { index: 2, hidden: true })
      }, { index: 1, displayMemberPath: 'наименование' })
    })
  });

  modelClass.defineProjection('ИндНапрМедосмL', 'i-i-s-uchet-medosmotrov3-инд-напр-медосм', {
    номерДок: attr('Номер док', { index: 0 }),
    дата: attr('Дата', { index: 1 }),
    медУчреждение: attr('Мед учреждение', { index: 2 }),
    сотрудники: belongsTo('i-i-s-uchet-medosmotrov3-сотрудники', 'ФИО', {
      фИО: attr('ФИО', { index: 3 })
    }, { index: -1, hidden: true }),
    организация: belongsTo('i-i-s-uchet-medosmotrov3-организация', 'Наименование', {
      наименование: attr('Наименование', { index: 4 })
    }, { index: -1, hidden: true })
  });
};
