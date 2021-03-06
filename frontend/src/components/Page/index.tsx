/* eslint-disable no-unused-vars */
import React, { forwardRef, useEffect, useCallback } from "react";
import type { HTMLProps, ReactNode } from "react";
import PropTypes from "prop-types";

// Helmet
import { Helmet } from "react-helmet";

// Router
import { useLocation } from "react-router-dom";

interface IPageProps extends HTMLProps<HTMLDivElement> {
  children?: ReactNode;
  title?: string;
}

const Page = forwardRef<HTMLDivElement, IPageProps>(
  ({ children, title = "", ...rest }, ref) => {
    const location = useLocation();

    // const sendPageViewEvent = useCallback(() => {
    //   track.pageview({
    //     page_path: location.pathname,
    //   });
    //   // eslint-disable-next-line react-hooks/exhaustive-deps
    // }, []);

    // useEffect(() => {
    //   sendPageViewEvent();
    // }, [sendPageViewEvent]);

    return (
      <div ref={ref as any} {...rest}>
        <Helmet>
          <title>{title}</title>
        </Helmet>
        {children}
      </div>
    );
  }
);

Page.propTypes = {
  children: PropTypes.node.isRequired,
  title: PropTypes.string,
};

export default Page;
