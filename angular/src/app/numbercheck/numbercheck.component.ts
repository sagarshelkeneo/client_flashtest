import {Component, Injector, ChangeDetectionStrategy, Injectable, OnInit, EventEmitter,
    Output } from '@angular/core';

import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';

import {
    NumberCheckServiceProxy,
    NumberCheckDto,
    CreateNumberCheckDto
} from '@shared/service-proxies/service-proxies';
import { forEach as _forEach, map as _map } from 'lodash-es';
import { FormGroup } from '@angular/forms';
import '@angular/compiler';
import { BsModalRef } from 'ngx-bootstrap/modal/public_api';
import { finalize } from 'rxjs/operators';

let calculatorServiceFactory = (ourStrategy: NumberValidation) => {
    return new CheckValidation(ourStrategy);
};


@Component({
    templateUrl: 'numbercheck.component.html',
    //providers: [
    //    {
    //        provide: NumberValidation, useClass: NoValue
    //    },
    //    CheckValidation,
    //]
})

export class NumberCheckComponent extends AppComponentBase
{
    OutputResult: string;

    InputNumber: string = '';
    private service: CheckValidation;

    saving = false;
    numbercheck = new NumberCheckDto();
    form: FormGroup = new FormGroup({});

    //constructor(
    //    injector: Injector,
    //    private _numberCheckService: NumberCheckServiceProxy
    //) {
    //    super(injector)
    //}

    
    //ngOnInit(): void {
    //}

    get f() {
        return this.form.controls;
    }
    submit() {
        // this.calculatorServiceFactory.getByCalc();
        //alert(this.entryNumber);
        if (this.InputNumber == '') {
            this.OutputResult = `No number entered, please enter a number.`;
        }

        if (Number(this.InputNumber) == NaN) {
            this.OutputResult = `Non-numeric value entered, please enter a number between 0 and 10.`;
        }

        if (Number(this.InputNumber) <= 0) {
            this.OutputResult = `Please enter a number between 0 and 10 (inclusive).`;
        }


        if (Number(this.InputNumber) >= 10) {
            this.OutputResult = `Please enter a number between 0 and 10 (inclusive).`;
        }

        if (Number(this.InputNumber) && Number(this.InputNumber) >= 0 && Number(this.InputNumber) <= 10) {
            this.OutputResult = (10 - Number(this.InputNumber)).toString();
            this.save();
        }


        //console.log(this.numberValidation.Test())
        //this.OutputResult = this.InputNumber
        console.log(this.InputNumber);
        //console.log(this.OutputResult);
    };
    save(): void {
        //this.saving = true;
        alert("Output number is:" + this.OutputResult);
        const numbercheck = new CreateNumberCheckDto();

        numbercheck.init(this.numbercheck);

        //this._numberCheckService
        //    .create(numbercheck)
        //    .pipe(
        //        finalize(() => {
        //            this.saving = false;
        //        })
        //    )
        //    .subscribe(() => {
        //        this.notify.info(this.l('SavedSuccessfully'));
        //        this.bsModalRef.hide();
        //    });
    }
}


@Injectable({
    providedIn: 'root' // just before your class
})
export abstract class NumberValidation {
    //constructor(public name: string) { }

    abstract CheckNumber(): void;
}

export class NoValue extends NumberValidation {
    CheckNumber() {
        console.log("NoValue")// + `${this.name}`);
        //if (num == '')
        /* console.log(`${this.name} is not a vlaue`);*/
        //return 'No number entered, please enter a number.';
    }
}

export class NonNumeric extends NumberValidation {
    CheckNumber() {
        console.log("NonNumeric")// + `${this.name}`);
        //console.log(`${this.name} is non numeric.`);
        //return "";
    }
}

export class NegativeNumber extends NumberValidation {
    CheckNumber() {
        console.log("NegativeNumber")// + `${this.name}`);
        //console.log(`${this.name} is negative number.`);
        //return "";
    }
}

export class GreaterNumber extends NumberValidation {
    CheckNumber() {
        console.log("GreaterNumber")// + `${this.name}`);
        //console.log(`${this.name} is greater than 10.`);
        //return "";
    }
}

export class CheckValidation {
    private ensemble: NumberValidation[] = [];
    constructor(
        private calcStrategy: NumberValidation) { };

    getByCalc() {
        console.log(`Result is: ${this.calcStrategy.CheckNumber()}`);
    }
    //recruit(num: NumberValidation) {
    //    this.ensemble = this.ensemble
    //        .filter(({ name }) => name === num.name)
    //        .concat(num);
    //}

    Test() {
        this.ensemble.forEach(data => data.CheckNumber());
    }
}
