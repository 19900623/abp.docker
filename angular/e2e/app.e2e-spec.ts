import { BpoTemplatePage } from './app.po';

describe('Bpo App', function() {
  let page: BpoTemplatePage;

  beforeEach(() => {
    page = new BpoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
