import { FlashTestTemplatePage } from './app.po';

describe('FlashTest App', function() {
  let page: FlashTestTemplatePage;

  beforeEach(() => {
    page = new FlashTestTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
